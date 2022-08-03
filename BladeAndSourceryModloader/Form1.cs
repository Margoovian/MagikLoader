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

namespace BladeAndSourceryModloader
{
    public partial class Form1 : Form
    {
        public Thread thread;

        public bool refreshing = false;
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
            manifests = new List<Manifest>();

            Regex rgx = new Regex("\"(.*?)\"");
            string ModPaths = Properties.Settings.Default.modFolderPaths+ "\"./downloadedmods\"";

            var mpaths = rgx.Matches(ModPaths);

            foreach (Match path in mpaths)
            {
                Console.WriteLine(path.Groups[1].ToString());
                if (Directory.Exists(path.Groups[1].ToString()))
                {
                    DirectoryInfo d = new DirectoryInfo(path.Groups[1].ToString());
                    foreach (var file in d.GetFiles())
                    {
                        using (Stream stream = File.OpenRead(file.FullName))
                        using (var reader = ReaderFactory.Open(stream))
                        {
                            
                            while (reader.MoveToNextEntry())
                            {
                                if(!full && Directory.Exists(@".\mods\" + reader.Entry)) { break; }
                                if (!reader.Entry.IsDirectory)
                                {
                                    reader.WriteEntryToDirectory(@".\mods", new ExtractionOptions()
                                    {
                                        ExtractFullPath = true,
                                        Overwrite = true
                                    });
                                }
                            }
                        }
                    }
                }
            }
            try
            {
                // Only get files that begin with the letter "c".
                string[] dirs = Directory.GetDirectories(@".\mods\");
                foreach (string dir in dirs)
                {
                    manifests.Add(JsonConvert.DeserializeObject<Manifest>(System.IO.File.ReadAllText(dir + @"\manifest.json")));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

        }
        private async void refresh_Click(object sender, EventArgs e)
        {
            refreshData(false);
        }

        private Task startRefresh(bool full)
        {
            modList.Controls.Clear();
            return Task.Run(() => refreshList(full)) ;

        }

        private void addModListButtons()
        {
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
        }

        private async void refreshData(bool full)
        {
            refresh.Enabled = false;
            reload.Enabled = false;
            await startRefresh(full);
            addModListButtons();
            refresh.Enabled = true;
            reload.Enabled = true;

            List<string> mods = new List<string>(); 
            foreach(modEnableButton modButton in modList.Controls)
            {
                mods.Add(modButton.Tag.ToString());
            }
            selectedMod.DataSource = mods;
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
    }
}
