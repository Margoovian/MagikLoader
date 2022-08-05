
namespace BladeAndSourceryModloader
{
    partial class settingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsPage));
            this.modPaths = new System.Windows.Forms.FlowLayoutPanel();
            this.gamePath = new System.Windows.Forms.TextBox();
            this.pathLink = new System.Windows.Forms.LinkLabel();
            this.addModDir = new System.Windows.Forms.Button();
            this.modDirPathsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modPaths
            // 
            this.modPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.modPaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPaths.Location = new System.Drawing.Point(13, 93);
            this.modPaths.Name = "modPaths";
            this.modPaths.Size = new System.Drawing.Size(409, 527);
            this.modPaths.TabIndex = 0;
            // 
            // gamePath
            // 
            this.gamePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.gamePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.gamePath.Location = new System.Drawing.Point(12, 32);
            this.gamePath.Name = "gamePath";
            this.gamePath.Size = new System.Drawing.Size(369, 26);
            this.gamePath.TabIndex = 1;
            this.gamePath.TextChanged += new System.EventHandler(this.gamePath_TextChanged);
            this.gamePath.Leave += new System.EventHandler(this.gamePath_Leave);
            // 
            // pathLink
            // 
            this.pathLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.pathLink.AutoSize = true;
            this.pathLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.pathLink.Location = new System.Drawing.Point(12, 9);
            this.pathLink.Name = "pathLink";
            this.pathLink.Size = new System.Drawing.Size(90, 20);
            this.pathLink.TabIndex = 2;
            this.pathLink.TabStop = true;
            this.pathLink.Text = "Game Path";
            this.pathLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            // 
            // addModDir
            // 
            this.addModDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addModDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.addModDir.Location = new System.Drawing.Point(326, 64);
            this.addModDir.Name = "addModDir";
            this.addModDir.Size = new System.Drawing.Size(95, 23);
            this.addModDir.TabIndex = 3;
            this.addModDir.Text = "Add +";
            this.addModDir.UseVisualStyleBackColor = true;
            this.addModDir.Click += new System.EventHandler(this.addModDir_Click);
            // 
            // modDirPathsLabel
            // 
            this.modDirPathsLabel.AutoSize = true;
            this.modDirPathsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDirPathsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.modDirPathsLabel.Location = new System.Drawing.Point(12, 64);
            this.modDirPathsLabel.Name = "modDirPathsLabel";
            this.modDirPathsLabel.Size = new System.Drawing.Size(134, 20);
            this.modDirPathsLabel.TabIndex = 4;
            this.modDirPathsLabel.Text = "Mod Folder Paths";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.button1.Location = new System.Drawing.Point(387, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.saveButton.Location = new System.Drawing.Point(13, 626);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // settingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(434, 661);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modDirPathsLabel);
            this.Controls.Add(this.addModDir);
            this.Controls.Add(this.pathLink);
            this.Controls.Add(this.gamePath);
            this.Controls.Add(this.modPaths);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 700);
            this.Name = "settingsPage";
            this.Load += new System.EventHandler(this.settingsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gamePath;
        private System.Windows.Forms.LinkLabel pathLink;
        private System.Windows.Forms.Button addModDir;
        private System.Windows.Forms.Label modDirPathsLabel;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.FlowLayoutPanel modPaths;
        private System.Windows.Forms.Button saveButton;
    }
}