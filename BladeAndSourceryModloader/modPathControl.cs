using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;

namespace BladeAndSourceryModloader
{
    public partial class modPathControl : UserControl
    {
        settingsPage SettingsPage;
        public modPathControl(settingsPage sp)
        {
            InitializeComponent();
            SettingsPage = sp;
        }

        private void path_TextChanged(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {
            SettingsPage.modPaths.Controls.Remove(this);
            SettingsPage.save();
        }

        public void SetPath(string modpath)
        {
            path.Text = modpath;
        }

        public string GetPath()
        {
            return path.Text;
        }

        private void path_Leave(object sender, EventArgs e)
        {
            SettingsPage.save();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Path.GetFullPath("./");
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path.Text = dialog.FileName;
            }
        }
    }
}
