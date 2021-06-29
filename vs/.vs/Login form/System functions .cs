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
    public partial class system_fn : Form
    {
        public system_fn()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_admin con = new Add_admin();
            con.Show();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_delete con = new Update_delete();
            con.Show();            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void welcome2_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            logout_Message con = new logout_Message();
            con.ShowDialog();
            this.Hide();
        }

        private void system_fn_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            logout_Message con = new logout_Message();
            con.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PenaltyBonus p = new PenaltyBonus();
            p.ShowDialog();
            this.Hide();
        }
    }
}
