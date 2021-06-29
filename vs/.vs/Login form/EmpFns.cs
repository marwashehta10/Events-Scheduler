using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Login_form
{
    public partial class EmpFns : Form
    {
        public EmpFns(string user)
        {
            InitializeComponent();
            label2.Text = user;
           
        }

        private void EmpFns_Load(object sender, EventArgs e)
        {
      
        }

        private void Bsalary_Click(object sender, EventArgs e)
        {
            Salary con = new Salary(label2.Text);
            con.Show();
            this.Hide();
        }

        private void Bdata_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            EmpData d = new EmpData(label2.Text);
            d.Show();

        }

        private void Blogout_Click(object sender, EventArgs e)
        {
            Rank x = new Rank(label2.Text);
            x.ShowDialog();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}