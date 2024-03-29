
namespace Logo_Quiz
{
    partial class LogoQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoQuiz));
            this.titlebar_panel = new System.Windows.Forms.Panel();
            this.minimize_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_screen = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_hard = new System.Windows.Forms.RadioButton();
            this.radioButton_easy = new System.Windows.Forms.RadioButton();
            this.radioButton_medium = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.play_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titlebar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebar_panel
            // 
            this.titlebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.titlebar_panel.Controls.Add(this.minimize_button);
            this.titlebar_panel.Controls.Add(this.close_button);
            this.titlebar_panel.Controls.Add(this.label_title);
            this.titlebar_panel.Controls.Add(this.pictureBox1);
            this.titlebar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar_panel.Location = new System.Drawing.Point(0, 0);
            this.titlebar_panel.Name = "titlebar_panel";
            this.titlebar_panel.Size = new System.Drawing.Size(1000, 40);
            this.titlebar_panel.TabIndex = 0;
            this.titlebar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebar_panel_MouseDown);
            this.titlebar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlebar_panel_MouseMove);
            this.titlebar_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlebar_panel_MouseUp);
            // 
            // minimize_button
            // 
            this.minimize_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize_button.BackgroundImage")));
            this.minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize_button.FlatAppearance.BorderSize = 0;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.Location = new System.Drawing.Point(920, 0);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(40, 40);
            this.minimize_button.TabIndex = 2;
            this.minimize_button.UseVisualStyleBackColor = true;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button.BackgroundImage")));
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Location = new System.Drawing.Point(960, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(40, 40);
            this.close_button.TabIndex = 2;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.label_title.Location = new System.Drawing.Point(449, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(101, 21);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Logo Quiz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel_screen
            // 
            this.panel_screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_screen.Location = new System.Drawing.Point(0, 40);
            this.panel_screen.Name = "panel_screen";
            this.panel_screen.Size = new System.Drawing.Size(1000, 660);
            this.panel_screen.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(450, 555);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 19);
            this.linkLabel1.TabIndex = 63;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Instructions";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.label3.Location = new System.Drawing.Point(318, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "Difficulty :";
            // 
            // radioButton_hard
            // 
            this.radioButton_hard.AutoSize = true;
            this.radioButton_hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_hard.Location = new System.Drawing.Point(616, 494);
            this.radioButton_hard.Name = "radioButton_hard";
            this.radioButton_hard.Size = new System.Drawing.Size(66, 24);
            this.radioButton_hard.TabIndex = 59;
            this.radioButton_hard.Text = "Hard";
            this.radioButton_hard.UseVisualStyleBackColor = true;
            // 
            // radioButton_easy
            // 
            this.radioButton_easy.AutoSize = true;
            this.radioButton_easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_easy.Location = new System.Drawing.Point(449, 494);
            this.radioButton_easy.Name = "radioButton_easy";
            this.radioButton_easy.Size = new System.Drawing.Size(66, 24);
            this.radioButton_easy.TabIndex = 61;
            this.radioButton_easy.Text = "Easy";
            this.radioButton_easy.UseVisualStyleBackColor = true;
            // 
            // radioButton_medium
            // 
            this.radioButton_medium.AutoSize = true;
            this.radioButton_medium.Checked = true;
            this.radioButton_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_medium.Location = new System.Drawing.Point(521, 494);
            this.radioButton_medium.Name = "radioButton_medium";
            this.radioButton_medium.Size = new System.Drawing.Size(89, 24);
            this.radioButton_medium.TabIndex = 60;
            this.radioButton_medium.TabStop = true;
            this.radioButton_medium.Text = "Medium";
            this.radioButton_medium.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 57);
            this.label2.TabIndex = 58;
            this.label2.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "Enter your name :";
            // 
            // name_textBox
            // 
            this.name_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textBox.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(402, 447);
            this.name_textBox.MaxLength = 17;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.ShortcutsEnabled = false;
            this.name_textBox.Size = new System.Drawing.Size(196, 28);
            this.name_textBox.TabIndex = 56;
            this.name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_textBox_KeyPress);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.ForeColor = System.Drawing.Color.Black;
            this.play_button.Location = new System.Drawing.Point(427, 590);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(145, 65);
            this.play_button.TabIndex = 55;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(375, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // LogoQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_hard);
            this.Controls.Add(this.radioButton_easy);
            this.Controls.Add(this.radioButton_medium);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel_screen);
            this.Controls.Add(this.titlebar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogoQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logo Quiz";
            this.Load += new System.EventHandler(this.LogoQuiz_Load);
            this.titlebar_panel.ResumeLayout(false);
            this.titlebar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlebar_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Panel panel_screen;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_hard;
        private System.Windows.Forms.RadioButton radioButton_easy;
        private System.Windows.Forms.RadioButton radioButton_medium;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

