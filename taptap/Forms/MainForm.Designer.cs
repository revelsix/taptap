namespace taptap
{
    partial class MainForm
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
            this.reset = new System.Windows.Forms.Button();
            this.key1Label = new System.Windows.Forms.Label();
            this.key2Label = new System.Windows.Forms.Label();
            this.key3Label = new System.Windows.Forms.Label();
            this.key4Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.Location = new System.Drawing.Point(235, 117);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 0;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // key1Label
            // 
            this.key1Label.AutoSize = true;
            this.key1Label.Location = new System.Drawing.Point(12, 17);
            this.key1Label.Name = "key1Label";
            this.key1Label.Size = new System.Drawing.Size(13, 13);
            this.key1Label.TabIndex = 1;
            this.key1Label.Text = "0";
            // 
            // key2Label
            // 
            this.key2Label.AutoSize = true;
            this.key2Label.Location = new System.Drawing.Point(50, 17);
            this.key2Label.Name = "key2Label";
            this.key2Label.Size = new System.Drawing.Size(13, 13);
            this.key2Label.TabIndex = 3;
            this.key2Label.Text = "0";
            // 
            // key3Label
            // 
            this.key3Label.AutoSize = true;
            this.key3Label.Location = new System.Drawing.Point(87, 17);
            this.key3Label.Name = "key3Label";
            this.key3Label.Size = new System.Drawing.Size(13, 13);
            this.key3Label.TabIndex = 4;
            this.key3Label.Text = "0";
            // 
            // key4Label
            // 
            this.key4Label.AutoSize = true;
            this.key4Label.Location = new System.Drawing.Point(124, 17);
            this.key4Label.Name = "key4Label";
            this.key4Label.Size = new System.Drawing.Size(13, 13);
            this.key4Label.TabIndex = 5;
            this.key4Label.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::taptap.Properties.Resources.key0image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(235, 146);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 176);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.key4Label);
            this.Controls.Add(this.key3Label);
            this.Controls.Add(this.key2Label);
            this.Controls.Add(this.key1Label);
            this.Controls.Add(this.reset);
            this.Name = "MainForm";
            this.Text = "taptap";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label key1Label;
        private System.Windows.Forms.Label key2Label;
        private System.Windows.Forms.Label key3Label;
        private System.Windows.Forms.Label key4Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button settingsButton;
    }
}

