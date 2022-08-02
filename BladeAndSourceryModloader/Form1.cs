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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            modList.HorizontalScroll.Maximum = 0;
            modList.AutoScroll = false;
            modList.VerticalScroll.Visible = false;
            modList.HorizontalScroll.Visible = false;
            modList.AutoScroll = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        private void scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void scroll(object sender, EventArgs e)
        {
        }
    }
}
