using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            changeData();
        }

        private void enabled_Click(object sender, EventArgs e)
        {
            if (enabedState)
            {
                enabled.Text = "";
            } else
            {
                enabled.Text = "✓";
            }
            enabedState = !enabedState;
        }

        public void changeData()
        {
            super.modName.Text = manifest.Name;
            super.description.Text = manifest.Description;
            super.author.Text = "By: " + manifest.Author;
            super.gameVersion.Text = "Game Version: " + manifest.GameVersion;
            super.modVersion.Text = manifest.ModVersion;
        }
    }
}
