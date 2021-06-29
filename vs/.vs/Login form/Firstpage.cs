using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_form
{
    public partial class Firstpage : Form
    {
        public Firstpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_screen con = new login_screen();
            con.ShowDialog();
            this.Hide();
        }

        private void welcome2_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Firstpage_Load(object sender, EventArgs e)
        {

        }

        private void Blogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
