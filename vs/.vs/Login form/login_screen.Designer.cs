namespace Login_form
{
    partial class login_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_screen));
            this.loginscreen_lbl = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginscreen_lbl
            // 
            this.loginscreen_lbl.AutoSize = true;
            this.loginscreen_lbl.BackColor = System.Drawing.Color.Transparent;
            this.loginscreen_lbl.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginscreen_lbl.ForeColor = System.Drawing.Color.Snow;
            this.loginscreen_lbl.Location = new System.Drawing.Point(4, 14);
            this.loginscreen_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginscreen_lbl.Name = "loginscreen_lbl";
            this.loginscreen_lbl.Size = new System.Drawing.Size(465, 87);
            this.loginscreen_lbl.TabIndex = 2;
            this.loginscreen_lbl.Text = "Login  Screen";
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.username_txt.Location = new System.Drawing.Point(27, 134);
            this.username_txt.Margin = new System.Windows.Forms.Padding(4);
            this.username_txt.Multiline = true;
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(444, 46);
            this.username_txt.TabIndex = 1;
            this.username_txt.Text = "Username";
            this.username_txt.TextChanged += new System.EventHandler(this.username_txt_TextChanged);
            this.username_txt.Enter += new System.EventHandler(this.username_txt_Enter);
            this.username_txt.Leave += new System.EventHandler(this.username_txt_Leave);
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.password_txt.Location = new System.Drawing.Point(27, 228);
            this.password_txt.Margin = new System.Windows.Forms.Padding(4);
            this.password_txt.Multiline = true;
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(444, 46);
            this.password_txt.TabIndex = 2;
            this.password_txt.Text = "Enter your password";
            this.password_txt.UseSystemPasswordChar = true;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            this.password_txt.Enter += new System.EventHandler(this.password_txt_Enter);
            this.password_txt.Leave += new System.EventHandler(this.password_txt_Leave);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DarkRed;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_btn.Location = new System.Drawing.Point(44, 307);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(197, 48);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, -32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close_btn.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Close_btn.Location = new System.Drawing.Point(274, 307);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(188, 48);
            this.Close_btn.TabIndex = 3;
            this.Close_btn.Text = "Exit";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(498, 381);
            this.ControlBox = false;
            this.Controls.Add(this.loginscreen_lbl);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login_screen";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginscreen_lbl;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button Close_btn;
    }
}