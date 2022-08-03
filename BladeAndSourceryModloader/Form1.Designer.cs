
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
            this.container = new System.Windows.Forms.SplitContainer();
            this.modVersion = new System.Windows.Forms.Label();
            this.gameVersion = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.modName = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.selectedMod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // modList
            // 
            this.modList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.modList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modList.Location = new System.Drawing.Point(13, 41);
            this.modList.Name = "modList";
            this.modList.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.modList.Size = new System.Drawing.Size(372, 579);
            this.modList.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.settings.Location = new System.Drawing.Point(292, 626);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(93, 23);
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
            this.refresh.Location = new System.Drawing.Point(101, 626);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(93, 23);
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
            this.build.Location = new System.Drawing.Point(193, 626);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(93, 23);
            this.build.TabIndex = 3;
            this.build.Text = "Build";
            this.build.UseVisualStyleBackColor = false;
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.container.Location = new System.Drawing.Point(391, 13);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.modVersion);
            this.container.Panel1.Controls.Add(this.gameVersion);
            this.container.Panel1.Controls.Add(this.author);
            this.container.Panel1.Controls.Add(this.description);
            this.container.Panel1.Controls.Add(this.modName);
            this.container.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.container.Panel1MinSize = 10;
            // 
            // container.Panel2
            // 
            this.container.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.container.Size = new System.Drawing.Size(841, 636);
            this.container.SplitterDistance = 79;
            this.container.TabIndex = 4;
            // 
            // modVersion
            // 
            this.modVersion.AutoSize = true;
            this.modVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.modVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modVersion.Location = new System.Drawing.Point(795, 0);
            this.modVersion.Margin = new System.Windows.Forms.Padding(0);
            this.modVersion.Name = "modVersion";
            this.modVersion.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.modVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.modVersion.Size = new System.Drawing.Size(44, 27);
            this.modVersion.TabIndex = 4;
            this.modVersion.Text = "0.0.0";
            this.modVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gameVersion
            // 
            this.gameVersion.AutoSize = true;
            this.gameVersion.Location = new System.Drawing.Point(5, 58);
            this.gameVersion.Name = "gameVersion";
            this.gameVersion.Size = new System.Drawing.Size(103, 13);
            this.gameVersion.TabIndex = 3;
            this.gameVersion.Text = "Game Version: 0.0.0";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(5, 45);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(61, 13);
            this.author.TabIndex = 2;
            this.author.Text = "By: Untitled";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(5, 32);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(60, 13);
            this.description.TabIndex = 1;
            this.description.Text = "Description";
            // 
            // modName
            // 
            this.modName.AutoSize = true;
            this.modName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modName.Location = new System.Drawing.Point(4, 8);
            this.modName.Name = "modName";
            this.modName.Size = new System.Drawing.Size(86, 20);
            this.modName.TabIndex = 0;
            this.modName.Text = "Mod Name";
            // 
            // reload
            // 
            this.reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.reload.Location = new System.Drawing.Point(13, 626);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(93, 23);
            this.reload.TabIndex = 5;
            this.reload.Text = "Reload";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // selectedMod
            // 
            this.selectedMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.selectedMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.selectedMod.FormattingEnabled = true;
            this.selectedMod.Location = new System.Drawing.Point(13, 14);
            this.selectedMod.Name = "selectedMod";
            this.selectedMod.Size = new System.Drawing.Size(372, 21);
            this.selectedMod.TabIndex = 6;
            this.selectedMod.SelectedIndexChanged += new System.EventHandler(this.selectedMod_indexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1244, 661);
            this.Controls.Add(this.selectedMod);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.container);
            this.Controls.Add(this.build);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.modList);
            this.MinimumSize = new System.Drawing.Size(1260, 700);
            this.Name = "Form1";
            this.Text = "Magik Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel modList;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.SplitContainer container;
        public System.Windows.Forms.Label modName;
        public System.Windows.Forms.Label modVersion;
        public System.Windows.Forms.Label gameVersion;
        public System.Windows.Forms.Label author;
        public System.Windows.Forms.Label description;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.ComboBox selectedMod;
        public System.Windows.Forms.Button build;
    }
}

