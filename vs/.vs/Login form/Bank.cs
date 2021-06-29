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
    public partial class Bank : Form
    {
        public Bank(string user)
        {
            InitializeComponent();
            label3.Text = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bank_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter a Your Credit number");
                this.Hide();
                Bank c = new Bank(label3.Text);
                c.Show();
            }

            else
            {
                SqlConnection con = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string ss = DateTime.Now.ToLongDateString();
                string qry = "Select Count(*) from Employee where Creditnumber ='" + textBox3.Text + "' and Username='" + label3.Text + "' Expirydate>'" +ss + "' ";

                SqlCommand command = new SqlCommand(qry, con);
                int result = Convert.ToInt32(command.ExecuteScalar());
                if (result > 0)
                {
                    EmpFns S = new EmpFns(label3.Text);
                    S.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a valid CreditNumber");
                    this.Hide();
                    Bank x = new Bank(label3.Text);
                    x.Show();


                }
                      if (con.State == ConnectionState.Open)
                    con.Close();

            }


        }
    }
}
