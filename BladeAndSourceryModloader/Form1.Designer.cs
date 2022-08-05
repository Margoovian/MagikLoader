
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.configLoadOrder = new System.Windows.Forms.SplitContainer();
            this.configPanel = new System.Windows.Forms.Panel();
            this.configLabel = new System.Windows.Forms.Label();
            this.loadorderPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.loadorderLabel = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.selectedMod = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configLoadOrder)).BeginInit();
            this.configLoadOrder.Panel1.SuspendLayout();
            this.configLoadOrder.Panel2.SuspendLayout();
            this.configLoadOrder.SuspendLayout();
            this.loadorderPanel.SuspendLayout();
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
            this.modList.Size = new System.Drawing.Size(372, 565);
            this.modList.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.settings.Location = new System.Drawing.Point(292, 612);
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
            this.refresh.Location = new System.Drawing.Point(101, 612);
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
            this.build.Location = new System.Drawing.Point(193, 612);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(93, 23);
            this.build.TabIndex = 3;
            this.build.Text = "Build";
            this.build.UseVisualStyleBackColor = false;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.container.IsSplitterFixed = true;
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
            this.container.Panel2.Controls.Add(this.configLoadOrder);
            this.container.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.container.Size = new System.Drawing.Size(841, 622);
            this.container.SplitterDistance = 77;
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
            // configLoadOrder
            // 
            this.configLoadOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configLoadOrder.Location = new System.Drawing.Point(0, 0);
            this.configLoadOrder.Name = "configLoadOrder";
            // 
            // configLoadOrder.Panel1
            // 
            this.configLoadOrder.Panel1.Controls.Add(this.configPanel);
            this.configLoadOrder.Panel1.Controls.Add(this.configLabel);
            this.configLoadOrder.Panel1MinSize = 50;
            // 
            // configLoadOrder.Panel2
            // 
            this.configLoadOrder.Panel2.Controls.Add(this.loadorderPanel);
            this.configLoadOrder.Panel2.Controls.Add(this.loadorderLabel);
            this.configLoadOrder.Size = new System.Drawing.Size(839, 539);
            this.configLoadOrder.SplitterDistance = 420;
            this.configLoadOrder.TabIndex = 0;
            // 
            // configPanel
            // 
            this.configPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configPanel.Location = new System.Drawing.Point(3, 32);
            this.configPanel.Name = "configPanel";
            this.configPanel.Size = new System.Drawing.Size(414, 504);
            this.configPanel.TabIndex = 1;
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configLabel.Location = new System.Drawing.Point(4, 9);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(55, 20);
            this.configLabel.TabIndex = 0;
            this.configLabel.Text = "Config";
            // 
            // loadorderPanel
            // 
            this.loadorderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadorderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadorderPanel.Controls.Add(this.richTextBox1);
            this.loadorderPanel.Location = new System.Drawing.Point(3, 32);
            this.loadorderPanel.Name = "loadorderPanel";
            this.loadorderPanel.Size = new System.Drawing.Size(409, 504);
            this.loadorderPanel.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(395, 490);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // loadorderLabel
            // 
            this.loadorderLabel.AutoSize = true;
            this.loadorderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadorderLabel.Location = new System.Drawing.Point(3, 9);
            this.loadorderLabel.Name = "loadorderLabel";
            this.loadorderLabel.Size = new System.Drawing.Size(124, 20);
            this.loadorderLabel.TabIndex = 1;
            this.loadorderLabel.Text = "Mod Load Order";
            // 
            // reload
            // 
            this.reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.reload.Location = new System.Drawing.Point(13, 612);
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
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.statusLabel.Location = new System.Drawing.Point(12, 639);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.progressBar1.Location = new System.Drawing.Point(391, 639);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(841, 13);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1244, 661);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.selectedMod);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.container);
            this.Controls.Add(this.build);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.modList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1260, 700);
            this.Name = "Form1";
            this.Text = "Magik Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel1.PerformLayout();
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.configLoadOrder.Panel1.ResumeLayout(false);
            this.configLoadOrder.Panel1.PerformLayout();
            this.configLoadOrder.Panel2.ResumeLayout(false);
            this.configLoadOrder.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configLoadOrder)).EndInit();
            this.configLoadOrder.ResumeLayout(false);
            this.loadorderPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SplitContainer configLoadOrder;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.Panel configPanel;
        private System.Windows.Forms.Panel loadorderPanel;
        public System.Windows.Forms.Label loadorderLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

