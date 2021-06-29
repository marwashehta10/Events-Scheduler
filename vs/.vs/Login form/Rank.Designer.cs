namespace Login_form
{
    partial class Rank
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.later_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "   ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "!, Would you like to rank our website ?!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(283, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 45);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "/5";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // later_btn
            // 
            this.later_btn.BackColor = System.Drawing.Color.Crimson;
            this.later_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.later_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.later_btn.FlatAppearance.BorderSize = 0;
            this.later_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.later_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.later_btn.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.later_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.later_btn.Location = new System.Drawing.Point(370, 124);
            this.later_btn.Margin = new System.Windows.Forms.Padding(4);
            this.later_btn.Name = "later_btn";
            this.later_btn.Size = new System.Drawing.Size(172, 52);
            this.later_btn.TabIndex = 16;
            this.later_btn.Text = "later";
            this.later_btn.UseVisualStyleBackColor = false;
            this.later_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Crimson;
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.save_btn.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.save_btn.Location = new System.Drawing.Point(138, 124);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(172, 52);
            this.save_btn.TabIndex = 17;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(672, 189);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.later_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rank";
            this.Load += new System.EventHandler(this.Rank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button later_btn;
        private System.Windows.Forms.Button save_btn;
    }
}