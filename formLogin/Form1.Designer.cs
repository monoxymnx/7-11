namespace formLogin
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
            this.b_login = new System.Windows.Forms.Button();
            this.t_username = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(155, 365);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(75, 23);
            this.b_login.TabIndex = 0;
            this.b_login.Text = "login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_username
            // 
            this.t_username.Location = new System.Drawing.Point(142, 250);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(100, 20);
            this.t_username.TabIndex = 1;
            this.t_username.Text = "Username";
            this.t_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_username.TextChanged += new System.EventHandler(this.t_username_TextChanged);
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(142, 289);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(100, 20);
            this.t_password.TabIndex = 2;
            this.t_password.Text = "Password";
            this.t_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_password.TextChanged += new System.EventHandler(this.t_password_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::formLogin.Properties.Resources._7_11;
            this.pictureBox1.Location = new System.Drawing.Point(112, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_username);
            this.Controls.Add(this.b_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.TextBox t_username;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

