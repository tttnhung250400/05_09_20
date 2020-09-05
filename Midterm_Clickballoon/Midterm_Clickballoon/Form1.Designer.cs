namespace Midterm_Clickballoon
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
            this.label1 = new System.Windows.Forms.Label();
            this.btChoi = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ravie", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(287, -2);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(859, 215);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Click Bóng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btChoi
            // 
            this.btChoi.BackColor = System.Drawing.Color.Beige;
            this.btChoi.Font = new System.Drawing.Font("Ravie", 22F);
            this.btChoi.Location = new System.Drawing.Point(271, 856);
            this.btChoi.Name = "btChoi";
            this.btChoi.Size = new System.Drawing.Size(318, 133);
            this.btChoi.TabIndex = 1;
            this.btChoi.Text = "Chơi";
            this.btChoi.UseVisualStyleBackColor = false;
            this.btChoi.Click += new System.EventHandler(this.btChoi_Click);
            // 
            // btDong
            // 
            this.btDong.BackColor = System.Drawing.Color.Beige;
            this.btDong.Font = new System.Drawing.Font("Ravie", 22F);
            this.btDong.Location = new System.Drawing.Point(810, 856);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(313, 133);
            this.btDong.TabIndex = 1;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = false;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = global::Midterm_Clickballoon.Properties.Resources.bunch_flower;
            this.pictureBox1.Location = new System.Drawing.Point(271, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 573);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1376, 1109);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btChoi);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.MaximumSize = new System.Drawing.Size(1404, 1188);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChoi;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

