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

        public modEnableButton()
        {
            InitializeComponent();
            
        }

        private void modButton_Click(object sender, EventArgs e)
        {

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

        public void SetName(string ModName)
        {
            modButton.Text = ModName;
        }
    }
}
