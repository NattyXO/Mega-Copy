
namespace copyer
{
    partial class popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popup));
            this.pnlBar = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picKeepBoth = new System.Windows.Forms.PictureBox();
            this.picSkipAll = new System.Windows.Forms.PictureBox();
            this.picSkip = new System.Windows.Forms.PictureBox();
            this.picOverwriteAll = new System.Windows.Forms.PictureBox();
            this.picOverwrite = new System.Windows.Forms.PictureBox();
            this.lblFile1CreatedDateAndTime = new System.Windows.Forms.Label();
            this.lblFile1Size = new System.Windows.Forms.Label();
            this.lblFile1Name = new System.Windows.Forms.Label();
            this.lblFile1Location = new System.Windows.Forms.Label();
            this.lblFile2Location = new System.Windows.Forms.Label();
            this.lblFile2Name = new System.Windows.Forms.Label();
            this.lblFilesTheSameSize = new System.Windows.Forms.Label();
            this.lblFilesCreatedTheSameDate = new System.Windows.Forms.Label();
            this.picFile2Logo = new System.Windows.Forms.PictureBox();
            this.picFile1Logo = new System.Windows.Forms.PictureBox();
            this.pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeepBoth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkipAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOverwriteAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOverwrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFile2Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFile1Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.Orange;
            this.pnlBar.Controls.Add(this.picClose);
            this.pnlBar.Controls.Add(this.pictureBox6);
            this.pnlBar.Controls.Add(this.label6);
            this.pnlBar.Location = new System.Drawing.Point(-2, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(461, 23);
            this.pnlBar.TabIndex = 0;
            this.pnlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseDown);
            // 
            // picClose
            // 
            this.picClose.Image = global::copyer.Properties.Resources.icons8_close_100;
            this.picClose.Location = new System.Drawing.Point(423, 1);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(27, 22);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 12;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::copyer.Properties.Resources.icons8_double_right_100;
            this.pictureBox6.Location = new System.Drawing.Point(2, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 17);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(34, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Destination File Already Exits";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picKeepBoth);
            this.panel2.Controls.Add(this.picSkipAll);
            this.panel2.Controls.Add(this.picSkip);
            this.panel2.Controls.Add(this.picOverwriteAll);
            this.panel2.Controls.Add(this.picOverwrite);
            this.panel2.Location = new System.Drawing.Point(-2, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 79);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(376, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Keep both";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(298, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Skip all";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(218, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Skip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Overwrite all";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Overwrite";
            // 
            // picKeepBoth
            // 
            this.picKeepBoth.Image = global::copyer.Properties.Resources.icons8_duplicate_96;
            this.picKeepBoth.Location = new System.Drawing.Point(375, 5);
            this.picKeepBoth.Name = "picKeepBoth";
            this.picKeepBoth.Size = new System.Drawing.Size(59, 50);
            this.picKeepBoth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKeepBoth.TabIndex = 4;
            this.picKeepBoth.TabStop = false;
            this.picKeepBoth.Click += new System.EventHandler(this.picKeepBoth_Click);
            // 
            // picSkipAll
            // 
            this.picSkipAll.Image = global::copyer.Properties.Resources.icons8_skip_64;
            this.picSkipAll.Location = new System.Drawing.Point(289, 5);
            this.picSkipAll.Name = "picSkipAll";
            this.picSkipAll.Size = new System.Drawing.Size(59, 50);
            this.picSkipAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSkipAll.TabIndex = 3;
            this.picSkipAll.TabStop = false;
            this.picSkipAll.Click += new System.EventHandler(this.picSkipAll_Click);
            // 
            // picSkip
            // 
            this.picSkip.Image = global::copyer.Properties.Resources.icons8_skip_100;
            this.picSkip.Location = new System.Drawing.Point(203, 5);
            this.picSkip.Name = "picSkip";
            this.picSkip.Size = new System.Drawing.Size(59, 50);
            this.picSkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSkip.TabIndex = 2;
            this.picSkip.TabStop = false;
            this.picSkip.Click += new System.EventHandler(this.picSkip_Click);
            // 
            // picOverwriteAll
            // 
            this.picOverwriteAll.Image = global::copyer.Properties.Resources.icons8_overwrite_clip_100__1_;
            this.picOverwriteAll.Location = new System.Drawing.Point(117, 5);
            this.picOverwriteAll.Name = "picOverwriteAll";
            this.picOverwriteAll.Size = new System.Drawing.Size(59, 50);
            this.picOverwriteAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOverwriteAll.TabIndex = 1;
            this.picOverwriteAll.TabStop = false;
            this.picOverwriteAll.Click += new System.EventHandler(this.picOverwriteAll_Click);
            // 
            // picOverwrite
            // 
            this.picOverwrite.Image = global::copyer.Properties.Resources.icons8_overwrite_clip_100;
            this.picOverwrite.Location = new System.Drawing.Point(31, 5);
            this.picOverwrite.Name = "picOverwrite";
            this.picOverwrite.Size = new System.Drawing.Size(59, 50);
            this.picOverwrite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOverwrite.TabIndex = 0;
            this.picOverwrite.TabStop = false;
            this.picOverwrite.Click += new System.EventHandler(this.picOverwrite_Click);
            // 
            // lblFile1CreatedDateAndTime
            // 
            this.lblFile1CreatedDateAndTime.AutoSize = true;
            this.lblFile1CreatedDateAndTime.ForeColor = System.Drawing.Color.White;
            this.lblFile1CreatedDateAndTime.Location = new System.Drawing.Point(321, 26);
            this.lblFile1CreatedDateAndTime.Name = "lblFile1CreatedDateAndTime";
            this.lblFile1CreatedDateAndTime.Size = new System.Drawing.Size(77, 13);
            this.lblFile1CreatedDateAndTime.TabIndex = 2;
            this.lblFile1CreatedDateAndTime.Text = "Date and Time";
            // 
            // lblFile1Size
            // 
            this.lblFile1Size.AutoSize = true;
            this.lblFile1Size.ForeColor = System.Drawing.Color.White;
            this.lblFile1Size.Location = new System.Drawing.Point(382, 49);
            this.lblFile1Size.Name = "lblFile1Size";
            this.lblFile1Size.Size = new System.Drawing.Size(46, 13);
            this.lblFile1Size.TabIndex = 3;
            this.lblFile1Size.Text = "File Size";
            // 
            // lblFile1Name
            // 
            this.lblFile1Name.AutoSize = true;
            this.lblFile1Name.ForeColor = System.Drawing.Color.White;
            this.lblFile1Name.Location = new System.Drawing.Point(53, 31);
            this.lblFile1Name.Name = "lblFile1Name";
            this.lblFile1Name.Size = new System.Drawing.Size(54, 13);
            this.lblFile1Name.TabIndex = 4;
            this.lblFile1Name.Text = "File Name";
            // 
            // lblFile1Location
            // 
            this.lblFile1Location.AutoSize = true;
            this.lblFile1Location.ForeColor = System.Drawing.Color.White;
            this.lblFile1Location.Location = new System.Drawing.Point(52, 48);
            this.lblFile1Location.Name = "lblFile1Location";
            this.lblFile1Location.Size = new System.Drawing.Size(67, 13);
            this.lblFile1Location.TabIndex = 5;
            this.lblFile1Location.Text = "File Location";
            // 
            // lblFile2Location
            // 
            this.lblFile2Location.AutoSize = true;
            this.lblFile2Location.ForeColor = System.Drawing.Color.White;
            this.lblFile2Location.Location = new System.Drawing.Point(52, 177);
            this.lblFile2Location.Name = "lblFile2Location";
            this.lblFile2Location.Size = new System.Drawing.Size(67, 13);
            this.lblFile2Location.TabIndex = 10;
            this.lblFile2Location.Text = "File Location";
            // 
            // lblFile2Name
            // 
            this.lblFile2Name.AutoSize = true;
            this.lblFile2Name.ForeColor = System.Drawing.Color.White;
            this.lblFile2Name.Location = new System.Drawing.Point(53, 161);
            this.lblFile2Name.Name = "lblFile2Name";
            this.lblFile2Name.Size = new System.Drawing.Size(54, 13);
            this.lblFile2Name.TabIndex = 9;
            this.lblFile2Name.Text = "File Name";
            // 
            // lblFilesTheSameSize
            // 
            this.lblFilesTheSameSize.AutoSize = true;
            this.lblFilesTheSameSize.ForeColor = System.Drawing.Color.White;
            this.lblFilesTheSameSize.Location = new System.Drawing.Point(377, 179);
            this.lblFilesTheSameSize.Name = "lblFilesTheSameSize";
            this.lblFilesTheSameSize.Size = new System.Drawing.Size(57, 13);
            this.lblFilesTheSameSize.TabIndex = 8;
            this.lblFilesTheSameSize.Text = "Same Size";
            // 
            // lblFilesCreatedTheSameDate
            // 
            this.lblFilesCreatedTheSameDate.AutoSize = true;
            this.lblFilesCreatedTheSameDate.ForeColor = System.Drawing.Color.White;
            this.lblFilesCreatedTheSameDate.Location = new System.Drawing.Point(375, 161);
            this.lblFilesCreatedTheSameDate.Name = "lblFilesCreatedTheSameDate";
            this.lblFilesCreatedTheSameDate.Size = new System.Drawing.Size(60, 13);
            this.lblFilesCreatedTheSameDate.TabIndex = 7;
            this.lblFilesCreatedTheSameDate.Text = "Same Date";
            // 
            // picFile2Logo
            // 
            this.picFile2Logo.Location = new System.Drawing.Point(5, 155);
            this.picFile2Logo.Name = "picFile2Logo";
            this.picFile2Logo.Size = new System.Drawing.Size(48, 43);
            this.picFile2Logo.TabIndex = 11;
            this.picFile2Logo.TabStop = false;
            // 
            // picFile1Logo
            // 
            this.picFile1Logo.Location = new System.Drawing.Point(5, 27);
            this.picFile1Logo.Name = "picFile1Logo";
            this.picFile1Logo.Size = new System.Drawing.Size(48, 43);
            this.picFile1Logo.TabIndex = 6;
            this.picFile1Logo.TabStop = false;
            // 
            // popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(453, 201);
            this.Controls.Add(this.picFile2Logo);
            this.Controls.Add(this.lblFile2Location);
            this.Controls.Add(this.lblFile2Name);
            this.Controls.Add(this.lblFilesTheSameSize);
            this.Controls.Add(this.lblFilesCreatedTheSameDate);
            this.Controls.Add(this.picFile1Logo);
            this.Controls.Add(this.lblFile1Location);
            this.Controls.Add(this.lblFile1Name);
            this.Controls.Add(this.lblFile1Size);
            this.Controls.Add(this.lblFile1CreatedDateAndTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "popup";
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeepBoth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkipAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOverwriteAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOverwrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFile2Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFile1Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picKeepBoth;
        private System.Windows.Forms.PictureBox picSkipAll;
        private System.Windows.Forms.PictureBox picSkip;
        private System.Windows.Forms.PictureBox picOverwriteAll;
        private System.Windows.Forms.PictureBox picOverwrite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFile1CreatedDateAndTime;
        private System.Windows.Forms.Label lblFile1Size;
        private System.Windows.Forms.Label lblFile1Name;
        private System.Windows.Forms.Label lblFile1Location;
        private System.Windows.Forms.PictureBox picFile1Logo;
        private System.Windows.Forms.PictureBox picFile2Logo;
        private System.Windows.Forms.Label lblFile2Location;
        private System.Windows.Forms.Label lblFile2Name;
        private System.Windows.Forms.Label lblFilesTheSameSize;
        private System.Windows.Forms.Label lblFilesCreatedTheSameDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox picClose;
    }
}