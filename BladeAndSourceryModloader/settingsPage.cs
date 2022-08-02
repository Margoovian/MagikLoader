using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace BladeAndSourceryModloader
{
    public partial class settingsPage : Form
    {
        public settingsPage()
        {
            InitializeComponent();

            modPaths.HorizontalScroll.Maximum = 0;
            modPaths.AutoScroll = false;
            modPaths.VerticalScroll.Visible = false;
            modPaths.HorizontalScroll.Visible = false;
            modPaths.AutoScroll = true;
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
            } else
            {
                gamePath.Text = "Please assign game folder!";
            }

            foreach(Match path in mpaths)
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
        }

        private void gamePath_Leave(object sender, EventArgs e)
        {
            this.save();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.save();
        }
    }
}
