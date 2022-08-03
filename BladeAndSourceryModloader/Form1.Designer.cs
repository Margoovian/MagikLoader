
namespace BladeAndSourceryModloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modList = new System.Windows.Forms.FlowLayoutPanel();
            this.settings = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.build = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modList
            // 
            this.modList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.modList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modList.Location = new System.Drawing.Point(13, 13);
            this.modList.Name = "modList";
            this.modList.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.modList.Size = new System.Drawing.Size(372, 607);
            this.modList.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.settings.Location = new System.Drawing.Point(1146, 13);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(86, 23);
            this.settings.TabIndex = 1;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.refresh.Location = new System.Drawing.Point(13, 626);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(86, 23);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // build
            // 
            this.build.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.build.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.build.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.build.Location = new System.Drawing.Point(105, 626);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(86, 23);
            this.build.TabIndex = 3;
            this.build.Text = "Build";
            this.build.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1244, 661);
            this.Controls.Add(this.build);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.modList);
            this.MinimumSize = new System.Drawing.Size(1260, 700);
            this.Name = "Form1";
            this.Text = "Magik Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel modList;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button build;
    }
}

