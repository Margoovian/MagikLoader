using Newtonsoft.Json;
using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SymbolicLinkSupport;

namespace BladeAndSourceryModloader
{
    public partial class Form1 : Form
    {

        public Thread thread;
        public bool refreshing = false;
        public string status
        {
            get { return _status; }
            set
            {
                _status = value;
                this.BeginInvoke(new MethodInvoker(setStatus));
            }
        }

        private string _status;

        public int progress
        {
            get { return _progress; }
            set
            {
                _progress = value;
                this.BeginInvoke(new MethodInvoker(delegate {
                    progressBar1.Visible = true;
                    progressBar1.Value = value;
                }));
            }
        }

        private int _progress;
        public bool Refreshing
        {
            get { return refreshing; }
            set
            {
                refreshing = value;
                Console.WriteLine(value);
                refresh.Enabled = !value;
            }
        }
        public List<Manifest> manifests = new List<Manifest>();
        public Form1()
        {
            InitializeComponent();
            modList.HorizontalScroll.Maximum = 0;
            modList.AutoScroll = false;
            modList.VerticalScroll.Visible = false;
            modList.HorizontalScroll.Visible = false;
            modList.AutoScroll = true;

            if (!Directory.Exists(Properties.Settings.Default.gamePath)) { build.Enabled = false; }
            if (!Directory.Exists(@".\staging")) { Directory.CreateDirectory(@".\staging"); }
            if (!Directory.Exists(@".\mods")) { Directory.CreateDirectory(@".\mods"); }
            if (!Directory.Exists(@".\modsettings")) { Directory.CreateDirectory(@".\modsettings"); }
            if (!Directory.Exists(@".\downloadedmods")) { Directory.CreateDirectory(@".\downloadedmods"); }

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            refreshData(false);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "settingsPage") { return; }
            }

            settingsPage settings = new settingsPage(this);
            settings.Show();

        }
        private async Task refreshList(bool full)
        {
            
            if (full)
            {
                DirectoryInfo di = new DirectoryInfo(@".\mods\");
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }

            }

            manifests = new List<Manifest>();
            Regex rgx2 = new Regex(@"config\.yaml");
            progress = 50;
            Regex rgx = new Regex("\"(.*?)\"");
            string ModPaths = Properties.Settings.Default.modFolderPaths+ "\"./downloadedmods\"";

            var mpaths = rgx.Matches(ModPaths);

            foreach (Match path in mpaths)
            {
                if (Directory.Exists(path.Groups[1].ToString()))
                {
                    int i = 0;
                    DirectoryInfo d = new DirectoryInfo(path.Groups[1].ToString());
                    float p;
                    
                    foreach (var file in d.GetFiles())
                    {
                        if (i <= 0 || d.GetFiles().Length <= 0) { p = 0; } else { p = i / (float)d.GetFiles().Length * 100f; }
                        progress = (int)Math.Floor(p);
                        i++;    
                        using (Stream stream = File.OpenRead(file.FullName))
                        using (var reader = ReaderFactory.Open(stream))
                        {
                            
                            while (reader.MoveToNextEntry())
                            {
                                
                                if (!full && Directory.Exists(@".\mods\" + reader.Entry)) { break; }
                                if (!reader.Entry.IsDirectory) 
                                {
                                    
                                    status = reader.Entry.ToString();
                                    reader.WriteEntryToDirectory(@".\mods", new ExtractionOptions()
                                    {
                                        ExtractFullPath = true,
                                        Overwrite = true
                                    });   
                                }
                                var cpaths = rgx2.Matches(reader.Entry.ToString());
                                foreach (Match c in cpaths)
                                {
                                    string cp = reader.Entry.ToString();
                                    string fp = Path.GetFullPath(@".\mods\" + cp).ToString();
                                    Directory.CreateDirectory(Path.Combine(@".\modsettings\", Path.GetDirectoryName(cp)));
                                    if (!File.Exists(Path.GetFullPath(@".\modsettings\" + cp))) { File.Copy(fp, Path.GetFullPath(@".\modsettings\" + cp), false); }
                                }
                            }
                        }
                    }
                }
            }
            try
            {
                string[] dirs = Directory.GetDirectories(@".\mods\");
                foreach (string dir in dirs)
                {
                    Manifest m = JsonConvert.DeserializeObject<Manifest>(System.IO.File.ReadAllText(dir + @"\manifest.json"));
                    m.FilePath = dir;
                    manifests.Add(m);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            progress = 0;
        }
        private async void refresh_Click(object sender, EventArgs e)
        {
            refreshData(false);
        }

        private Task startRefresh(bool full)
        {
            
            return Task.Run(() => refreshList(full)) ;

        }

        private void addModListButtons()
        {
            modList.Controls.Clear();
            foreach (Manifest manifest in manifests)
            {
                modEnableButton modButton = new modEnableButton(manifest, this);
                modButton.Tag = manifest.Name;
                modList.Controls.Add(modButton);
            }
        }

        private async void reload_Click(object sender, EventArgs e)
        {
            refreshData(true);
            if(build.Enabled == true)
            {
                buildActiveMods();
            }
            
        }

        private async void refreshData(bool full)
        {
            refresh.Enabled = false;
            reload.Enabled = false;
            build.Enabled = false;
            await startRefresh(full);
            addModListButtons();
            refresh.Enabled = true;
            reload.Enabled = true;
            status = "";
            progressBar1.Visible = false;

            if (File.Exists($"{Properties.Settings.Default.gamePath}/BladeAndSorcery.exe")) {
                build.Enabled = true;
            }

            List<string> mods = new List<string>(); 
            foreach(modEnableButton modButton in modList.Controls)
            {
                mods.Add(modButton.Tag.ToString());
            }
            selectedMod.DataSource = mods;
        }

        private void setStatus()
        {
            statusLabel.Text = status;
        }

        private void selectedMod_indexChanged(object sender, EventArgs e)
        {
            foreach (modEnableButton modButton in modList.Controls)
            {
                if(modButton.Tag.ToString() == selectedMod.SelectedValue.ToString())
                {
                    modButton.changeData();
                    modButton.modButton.Focus();
                    break;
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            List<string> formats = new List<string> { ".zip", ".rar", ".tar", ".gzip",".xz", ".7z", ".7zip"};
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);    
            foreach (string file in files) {
                if (formats.Contains(Path.GetExtension(file)))
                {
                    Directory.Move(file, @"./downloadedmods/" + Path.GetFileName(file));
                }
            }
        }

        private void build_Click(object sender, EventArgs e)
        {
            buildActiveMods();
        }

        private void buildActiveMods()
        {
            DirectoryInfo di = new DirectoryInfo($"{Properties.Settings.Default.gamePath}/BladeAndSorcery_Data/StreamingAssets/Mods");
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            Regex rgx = new Regex("\"(.*?)\"");
            string ActiveMods = Properties.Settings.Default.activeMods;
            var amods = rgx.Matches(ActiveMods);
            foreach (Match mod in amods)
            {
                if (Directory.Exists($"./mods/{mod.Groups[1]}"))
                {
                    DirectoryInfo directory = new DirectoryInfo($"./mods/{mod.Groups[1]}");
                    string path = $"{Properties.Settings.Default.gamePath}/BladeAndSorcery_Data/StreamingAssets/Mods/{mod.Groups[1]}";
                    Console.WriteLine($"./mods/{mod.Groups[1]} | {Path.GetFullPath($"./mods/{mod.Groups[1]}")} | {Properties.Settings.Default.gamePath}/BladeAndSorcery_Data/StreamingAssets/Mods/{mod.Groups[1]}");
                    SymbolicLinkSupport.DirectoryInfoExtensions.CreateSymbolicLink(directory, path, false);
                }
            }
        }
    }
}
