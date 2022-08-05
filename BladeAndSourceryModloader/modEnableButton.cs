using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BladeAndSourceryModloader
{
    public partial class modEnableButton : UserControl
    {
        public Boolean enabedState = false;
        private Form1 super;
        private Manifest manifest;

        public modEnableButton(Manifest m, Form1 main)
        {
            InitializeComponent();
            modButton.Text = m.Name;
            manifest = m;
            this.Size = new Size(348, 60);
            this.super = main;

            Regex rgx = new Regex("\"(.*?)\"");
            string ActiveMods = Properties.Settings.Default.activeMods;

            var amods = rgx.Matches(ActiveMods);
            foreach (Match mod in amods)
            {
                if (mod.Groups[1].ToString() == manifest.Name)
                {
                    enabedState = true;
                    enabled.Text = "✓";
                }
            }
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            changeData();
        }

        private async void enabled_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex("\"(.*?)\"");
            string ActiveMods = Properties.Settings.Default.activeMods;

            var amods = rgx.Matches(ActiveMods);

            if (enabedState)
            {
                enabled.Text = "";
                
            } else
            {
                enabled.Text = "✓";
            }
            enabedState = !enabedState;
            await changeActiveModState();

        }

        public void changeData()
        {
            super.modName.Text = manifest.Name;
            super.description.Text = manifest.Description;
            super.author.Text = "By: " + manifest.Author;
            super.gameVersion.Text = "Game Version: " + manifest.GameVersion;
            super.modVersion.Text = manifest.ModVersion;
        }

        public async Task changeActiveModState()
        {
            Regex rgx = new Regex("\"(.*?)\"");
            string ActiveMods = Properties.Settings.Default.activeMods;
            string totalMods = "";
            var amods = rgx.Matches(ActiveMods);
            foreach (Match mod in amods)
            {
                if (mod.Groups[1].ToString() != manifest.Name)
                {
                    totalMods = totalMods + ($"\"{mod.Groups[1]}\"");
                }

            }
            
            if (enabedState)
            {
                totalMods = totalMods + ($"\"{Path.GetFileName(manifest.FilePath)}\"");
            }
            Properties.Settings.Default.activeMods = totalMods;
            Properties.Settings.Default.Save();
        }
    }
}
