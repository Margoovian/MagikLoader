using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace BladeAndSourceryModloader
{
    public partial class Form1 : Form
    {
        public Thread thread;
        public Form1()
        {
            InitializeComponent();
            modList.HorizontalScroll.Maximum = 0;
            modList.AutoScroll = false;
            modList.VerticalScroll.Visible = false;
            modList.HorizontalScroll.Visible = false;
            modList.AutoScroll = true;

            if (!Directory.Exists(@".\staging")) { Directory.CreateDirectory(@".\staging"); }
            if (!Directory.Exists(@".\mods")) { Directory.CreateDirectory(@".\mods"); }

            thread = new Thread(this.refreshList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!thread.IsAlive)
            {
                thread = new Thread(this.refreshList);
                thread.Start();
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "settingsPage") { return; }
            }

            settingsPage settings = new settingsPage();
            settings.Show();

        }
        private void refreshList()
        {
            Regex rgx = new Regex(@"manifest\.json"); //Unpacks Zip file until manifest.json 
            bool flag = false;
            if (Directory.Exists(Properties.Settings.Default.gamePath))
            {
                DirectoryInfo d = new DirectoryInfo(Properties.Settings.Default.gamePath);
                foreach (var file in d.GetFiles())
                {
                    using (Stream stream = File.OpenRead(file.FullName))
                    using (var reader = ReaderFactory.Open(stream))
                    {
                        while (reader.MoveToNextEntry())
                        {
                            if (!reader.Entry.IsDirectory)
                            {
                                var rgxpaths = rgx.Matches(reader.Entry.ToString());
                                Console.WriteLine(reader.Entry.Key);
                                foreach (Match r in rgxpaths) { flag = true; }
                                reader.WriteEntryToDirectory(@".\staging", new ExtractionOptions()
                                {
                                    ExtractFullPath = true,
                                    Overwrite = true
                                });
                                if (flag) { flag = false; break; }
                            }
                        }
                    }
                }
            }


        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (!thread.IsAlive)
            {
                thread = new Thread(this.refreshList);
                thread.Start();
            }
        }
    }
}
