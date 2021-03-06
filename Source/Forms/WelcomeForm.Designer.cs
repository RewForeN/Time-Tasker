﻿namespace TimeTasker {
	partial class WelcomeForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblWelcome = new System.Windows.Forms.Label();
			this.lblAppname = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnProceed = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnProceed)).BeginInit();
			this.SuspendLayout();
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.ForeColor = System.Drawing.Color.White;
			this.lblWelcome.Location = new System.Drawing.Point(209, 723);
			this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(164, 39);
			this.lblWelcome.TabIndex = 0;
			this.lblWelcome.Text = "Welcome";
			// 
			// lblAppname
			// 
			this.lblAppname.AutoSize = true;
			this.lblAppname.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppname.ForeColor = System.Drawing.Color.White;
			this.lblAppname.Location = new System.Drawing.Point(100, 123);
			this.lblAppname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAppname.Name = "lblAppname";
			this.lblAppname.Size = new System.Drawing.Size(273, 51);
			this.lblAppname.TabIndex = 3;
			this.lblAppname.Text = "Time Tasker";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TimeTasker.Properties.Resources.AppLogo;
			this.pictureBox1.Location = new System.Drawing.Point(167, 215);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(133, 123);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// btnProceed
			// 
			this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProceed.Image = global::TimeTasker.Properties.Resources.ProceedIconSelected;
			this.btnProceed.Location = new System.Drawing.Point(385, 718);
			this.btnProceed.Margin = new System.Windows.Forms.Padding(4);
			this.btnProceed.Name = "btnProceed";
			this.btnProceed.Size = new System.Drawing.Size(50, 50);
			this.btnProceed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnProceed.TabIndex = 1;
			this.btnProceed.TabStop = false;
			this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
			// 
			// WelcomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(480, 800);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblAppname);
			this.Controls.Add(this.btnProceed);
			this.Controls.Add(this.lblWelcome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "WelcomeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WelcomeForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnProceed)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.PictureBox btnProceed;
		private System.Windows.Forms.Label lblAppname;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}