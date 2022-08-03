
namespace BladeAndSourceryModloader
{
    partial class modEnableButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modButton = new System.Windows.Forms.Button();
            this.enabled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modButton
            // 
            this.modButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.modButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.modButton.Location = new System.Drawing.Point(0, 0);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(249, 60);
            this.modButton.TabIndex = 0;
            this.modButton.Text = "button1";
            this.modButton.UseVisualStyleBackColor = false;
            this.modButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // enabled
            // 
            this.enabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.enabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(198)))), ((int)(((byte)(67)))));
            this.enabled.Location = new System.Drawing.Point(255, 5);
            this.enabled.Name = "enabled";
            this.enabled.Size = new System.Drawing.Size(50, 50);
            this.enabled.TabIndex = 1;
            this.enabled.UseVisualStyleBackColor = false;
            this.enabled.Click += new System.EventHandler(this.enabled_Click);
            // 
            // modEnableButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.enabled);
            this.Controls.Add(this.modButton);
            this.Name = "modEnableButton";
            this.Size = new System.Drawing.Size(310, 60);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button enabled;
        public System.Windows.Forms.Button modButton;
    }
}
