using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BladeAndSourceryModloader
{
    public partial class settingsPage : Form
    {
        Form1 super;
        public settingsPage(Form1 main)
        {
            InitializeComponent();

            modPaths.HorizontalScroll.Maximum = 0;
            modPaths.AutoScroll = false;
            modPaths.VerticalScroll.Visible = false;
            modPaths.HorizontalScroll.Visible = false;
            modPaths.AutoScroll = true;
            super = main;
        }

        private void settingsPage_Load(object sender, EventArgs e)
        {
            Regex rgx = new Regex("\"(.*?)\"");
            string ModPaths = Properties.Settings.Default.modFolderPaths;
            string GamePath = Properties.Settings.Default.gamePath;

            var mpaths = rgx.Matches(ModPaths);

            if (GamePath != "")
            {
                gamePath.Text = GamePath;
            }
            else
            {
                gamePath.Text = "Please assign game folder!";
            }

            foreach (Match path in mpaths)
            {
                modPathControl modfolder = new modPathControl(this);
                modfolder.Size = new Size(400, 26);
                modfolder.SetPath(path.Groups[1].ToString());
                modPaths.Controls.Add(modfolder);
            }
        }

        private void addModDir_Click(object sender, EventArgs e)
        {
            modPathControl modfolder = new modPathControl(this);
            modfolder.Size = new Size(400, 26);
            modPaths.Controls.Add(modfolder);
        }

        public void save()
        {
            Properties.Settings.Default.gamePath = "";
            Properties.Settings.Default.modFolderPaths = "";

            string finalmodpaths = "";
            foreach (modPathControl modpathcontrol in modPaths.Controls)
            {
                if (Directory.Exists(modpathcontrol.GetPath()))
                {
                    if (modpathcontrol.GetPath() != "") { finalmodpaths = finalmodpaths + "\"" + modpathcontrol.GetPath() + "\""; }

                }
            }
            Console.WriteLine(finalmodpaths);
            if (Directory.Exists(gamePath.Text))
            {
                Properties.Settings.Default.gamePath = gamePath.Text;
            }

            Properties.Settings.Default.modFolderPaths = finalmodpaths;
            Properties.Settings.Default.Save();

            if (Directory.Exists(gamePath.Text)) { super.build.Enabled = true; }
            else { super.build.Enabled = false; }
        }

        private void gamePath_Leave(object sender, EventArgs e)
        {
            this.save();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.save();
        }

        private void gamePath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(gamePath.Text)) { super.build.Enabled = true; }
            else { super.build.Enabled = false; }
        }
    }
}
