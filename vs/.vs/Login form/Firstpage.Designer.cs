namespace Login_form
{
    partial class Firstpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firstpage));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.click_btn = new System.Windows.Forms.Button();
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.welcome2_lbl = new System.Windows.Forms.Label();
            this.Blogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // click_btn
            // 
            this.click_btn.BackColor = System.Drawing.Color.DarkRed;
            this.click_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.click_btn.FlatAppearance.BorderSize = 0;
            this.click_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.click_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.click_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.click_btn.Font = new System.Drawing.Font("Forte", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.click_btn.Location = new System.Drawing.Point(807, 778);
            this.click_btn.Margin = new System.Windows.Forms.Padding(4);
            this.click_btn.Name = "click_btn";
            this.click_btn.Size = new System.Drawing.Size(541, 64);
            this.click_btn.TabIndex = 0;
            this.click_btn.Text = "Click here to login";
            this.click_btn.UseVisualStyleBackColor = false;
            this.click_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome_lbl
            // 
            this.Welcome_lbl.AutoSize = true;
            this.Welcome_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_lbl.Font = new System.Drawing.Font("Forte", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.Welcome_lbl.Location = new System.Drawing.Point(109, 11);
            this.Welcome_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome_lbl.Name = "Welcome_lbl";
            this.Welcome_lbl.Size = new System.Drawing.Size(868, 264);
            this.Welcome_lbl.TabIndex = 1;
            this.Welcome_lbl.Text = "Welcome to the \r\n                  ";
            // 
            // welcome2_lbl
            // 
            this.welcome2_lbl.AutoSize = true;
            this.welcome2_lbl.BackColor = System.Drawing.Color.Transparent;
            this.welcome2_lbl.Font = new System.Drawing.Font("Forte", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome2_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.welcome2_lbl.Location = new System.Drawing.Point(284, 139);
            this.welcome2_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome2_lbl.Name = "welcome2_lbl";
            this.welcome2_lbl.Size = new System.Drawing.Size(1384, 132);
            this.welcome2_lbl.TabIndex = 2;
            this.welcome2_lbl.Text = "           Recruitment system";
            this.welcome2_lbl.Click += new System.EventHandler(this.welcome2_lbl_Click);
            // 
            // Blogout
            // 
            this.Blogout.BackColor = System.Drawing.Color.Transparent;
            this.Blogout.BackgroundImage = global::Login_form.Properties.Resources.session_icon_16;
            this.Blogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Blogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Blogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blogout.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blogout.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Blogout.Location = new System.Drawing.Point(1892, 11);
            this.Blogout.Margin = new System.Windows.Forms.Padding(4);
            this.Blogout.Name = "Blogout";
            this.Blogout.Size = new System.Drawing.Size(47, 44);
            this.Blogout.TabIndex = 7;
            this.Blogout.UseVisualStyleBackColor = false;
            this.Blogout.Click += new System.EventHandler(this.Blogout_Click);
            // 
            // Firstpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_form.Properties.Resources.man_in_white_dress_shirt_sitting_on_black_and_white_tube_931887;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Blogout);
            this.Controls.Add(this.welcome2_lbl);
            this.Controls.Add(this.Welcome_lbl);
            this.Controls.Add(this.click_btn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Firstpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Firstpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button click_btn;
        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.Label welcome2_lbl;
        private System.Windows.Forms.Button Blogout;
    }
}

