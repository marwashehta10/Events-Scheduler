namespace Login_form
{
    partial class Empty_password
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
            this.ok_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.DarkRed;
            this.ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ok_btn.FlatAppearance.BorderSize = 0;
            this.ok_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ok_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_btn.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ok_btn.Location = new System.Drawing.Point(137, 47);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(90, 42);
            this.ok_btn.TabIndex = 7;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please Enter your Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Empty_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(391, 102);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empty_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empty_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label label1;
    }
}