namespace copyer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnOpenFileLocation = new System.Windows.Forms.Button();
            this.btnDestinationLocation = new System.Windows.Forms.Button();
            this.btnCopyandOverwrite = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCutandOverwrite = new System.Windows.Forms.Button();
            this.btnCopyandDuplicate = new System.Windows.Forms.Button();
            this.btnCutandDuplicate = new System.Windows.Forms.Button();
            this.picGitHub = new System.Windows.Forms.PictureBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(83, 52);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(318, 20);
            this.txtSource.TabIndex = 3;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(83, 95);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(318, 20);
            this.txtTarget.TabIndex = 4;
            // 
            // btnOpenFileLocation
            // 
            this.btnOpenFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnOpenFileLocation.FlatAppearance.BorderSize = 0;
            this.btnOpenFileLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFileLocation.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpenFileLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFileLocation.Image")));
            this.btnOpenFileLocation.Location = new System.Drawing.Point(413, 38);
            this.btnOpenFileLocation.Name = "btnOpenFileLocation";
            this.btnOpenFileLocation.Size = new System.Drawing.Size(47, 43);
            this.btnOpenFileLocation.TabIndex = 5;
            this.btnOpenFileLocation.Text = ".....";
            this.btnOpenFileLocation.UseVisualStyleBackColor = false;
            this.btnOpenFileLocation.Click += new System.EventHandler(this.btnOpenFileLocation_Click);
            // 
            // btnDestinationLocation
            // 
            this.btnDestinationLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDestinationLocation.FlatAppearance.BorderSize = 0;
            this.btnDestinationLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinationLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestinationLocation.ForeColor = System.Drawing.Color.Transparent;
            this.btnDestinationLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnDestinationLocation.Image")));
            this.btnDestinationLocation.Location = new System.Drawing.Point(417, 93);
            this.btnDestinationLocation.Name = "btnDestinationLocation";
            this.btnDestinationLocation.Size = new System.Drawing.Size(37, 22);
            this.btnDestinationLocation.TabIndex = 6;
            this.btnDestinationLocation.UseVisualStyleBackColor = false;
            this.btnDestinationLocation.Click += new System.EventHandler(this.btnDestinationLocation_Click);
            // 
            // btnCopyandOverwrite
            // 
            this.btnCopyandOverwrite.BackColor = System.Drawing.Color.Orange;
            this.btnCopyandOverwrite.FlatAppearance.BorderSize = 0;
            this.btnCopyandOverwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyandOverwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyandOverwrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnCopyandOverwrite.Location = new System.Drawing.Point(110, 161);
            this.btnCopyandOverwrite.Name = "btnCopyandOverwrite";
            this.btnCopyandOverwrite.Size = new System.Drawing.Size(151, 23);
            this.btnCopyandOverwrite.TabIndex = 7;
            this.btnCopyandOverwrite.Text = "Copy and Overwrite";
            this.btnCopyandOverwrite.UseVisualStyleBackColor = false;
            this.btnCopyandOverwrite.Click += new System.EventHandler(this.btnCopyandOverwrite_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(12, 137);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(431, 18);
            this.ProgressBar1.TabIndex = 8;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(415, 118);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(18, 20);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "0";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(390, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 23);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(426, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 24);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(38, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "MegaCopy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "MEGA";
            // 
            // btnCutandOverwrite
            // 
            this.btnCutandOverwrite.BackColor = System.Drawing.Color.Orange;
            this.btnCutandOverwrite.FlatAppearance.BorderSize = 0;
            this.btnCutandOverwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCutandOverwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCutandOverwrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnCutandOverwrite.Location = new System.Drawing.Point(298, 190);
            this.btnCutandOverwrite.Name = "btnCutandOverwrite";
            this.btnCutandOverwrite.Size = new System.Drawing.Size(138, 23);
            this.btnCutandOverwrite.TabIndex = 9;
            this.btnCutandOverwrite.Text = "Cut and Overwrite";
            this.btnCutandOverwrite.UseVisualStyleBackColor = false;
            this.btnCutandOverwrite.Click += new System.EventHandler(this.btnCutandOverwrite_Click);
            // 
            // btnCopyandDuplicate
            // 
            this.btnCopyandDuplicate.BackColor = System.Drawing.Color.Orange;
            this.btnCopyandDuplicate.FlatAppearance.BorderSize = 0;
            this.btnCopyandDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyandDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyandDuplicate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnCopyandDuplicate.Location = new System.Drawing.Point(291, 161);
            this.btnCopyandDuplicate.Name = "btnCopyandDuplicate";
            this.btnCopyandDuplicate.Size = new System.Drawing.Size(152, 23);
            this.btnCopyandDuplicate.TabIndex = 10;
            this.btnCopyandDuplicate.Text = "Copy and Duplicate";
            this.btnCopyandDuplicate.UseVisualStyleBackColor = false;
            this.btnCopyandDuplicate.Click += new System.EventHandler(this.btnCopyandDuplicate_Click);
            // 
            // btnCutandDuplicate
            // 
            this.btnCutandDuplicate.BackColor = System.Drawing.Color.Orange;
            this.btnCutandDuplicate.FlatAppearance.BorderSize = 0;
            this.btnCutandDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCutandDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCutandDuplicate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnCutandDuplicate.Location = new System.Drawing.Point(116, 190);
            this.btnCutandDuplicate.Name = "btnCutandDuplicate";
            this.btnCutandDuplicate.Size = new System.Drawing.Size(138, 23);
            this.btnCutandDuplicate.TabIndex = 11;
            this.btnCutandDuplicate.Text = "Cut and Duplicate";
            this.btnCutandDuplicate.UseVisualStyleBackColor = false;
            this.btnCutandDuplicate.Click += new System.EventHandler(this.btnCutandDuplicate_Click);
            // 
            // picGitHub
            // 
            this.picGitHub.Image = ((System.Drawing.Image)(resources.GetObject("picGitHub.Image")));
            this.picGitHub.Location = new System.Drawing.Point(58, 185);
            this.picGitHub.Name = "picGitHub";
            this.picGitHub.Size = new System.Drawing.Size(32, 27);
            this.picGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGitHub.TabIndex = 12;
            this.picGitHub.TabStop = false;
            this.picGitHub.Click += new System.EventHandler(this.picGitHub_Click);
            // 
            // picInfo
            // 
            this.picInfo.Image = global::copyer.Properties.Resources.icons8_info_240;
            this.picInfo.Location = new System.Drawing.Point(11, 185);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(32, 27);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInfo.TabIndex = 13;
            this.picInfo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(459, 218);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.picGitHub);
            this.Controls.Add(this.btnCutandDuplicate);
            this.Controls.Add(this.btnCopyandDuplicate);
            this.Controls.Add(this.btnCutandOverwrite);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.btnCopyandOverwrite);
            this.Controls.Add(this.btnDestinationLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOpenFileLocation);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 218);
            this.MinimumSize = new System.Drawing.Size(459, 218);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnOpenFileLocation;
        private System.Windows.Forms.Button btnDestinationLocation;
        private System.Windows.Forms.Button btnCopyandOverwrite;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCutandOverwrite;
        private System.Windows.Forms.Button btnCopyandDuplicate;
        private System.Windows.Forms.Button btnCutandDuplicate;
        private System.Windows.Forms.PictureBox picGitHub;
        private System.Windows.Forms.PictureBox picInfo;
    }
}

