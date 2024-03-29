
namespace Logo_Quiz
{
    partial class ResultBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultBoard));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_home = new System.Windows.Forms.Button();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(425, 178);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // button_home
            // 
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Image = ((System.Drawing.Image)(resources.GetObject("button_home.Image")));
            this.button_home.Location = new System.Drawing.Point(450, 501);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(100, 100);
            this.button_home.TabIndex = 2;
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // textBox_status
            // 
            this.textBox_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBox_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_status.Font = new System.Drawing.Font("Georgia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_status.Location = new System.Drawing.Point(200, 48);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(600, 110);
            this.textBox_status.TabIndex = 5;
            this.textBox_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_score
            // 
            this.textBox_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBox_score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_score.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold);
            this.textBox_score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.textBox_score.Location = new System.Drawing.Point(250, 360);
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.Size = new System.Drawing.Size(500, 43);
            this.textBox_score.TabIndex = 6;
            this.textBox_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_message
            // 
            this.textBox_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBox_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_message.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold);
            this.textBox_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.textBox_message.Location = new System.Drawing.Point(250, 433);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(500, 43);
            this.textBox_message.TabIndex = 6;
            this.textBox_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.textBox_score);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_home);
            this.Name = "ResultBoard";
            this.Size = new System.Drawing.Size(1000, 660);
            this.Load += new System.EventHandler(this.ResultBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.TextBox textBox_message;
    }
}
