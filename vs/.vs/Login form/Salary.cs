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
    public partial class Salary : Form
    {
        public Salary(string user)
        {
            InitializeComponent();
            label6.Text = user;
            SqlConnection con = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
            con.Open();
            string qry = "Select netsalary,Currentsalary,discount,discountdetails,bonus,Bonusdetails from [Employee],Salary,Discount,Bonus where Username='" + user + "' ";
            SqlCommand command = new SqlCommand(qry, con);
            SqlDataReader enter = command.ExecuteReader();
            if (enter.Read())
            {
                currentsalary_txt.Text = (enter["Currentsalary"].ToString());
                netsalary_txt.Text = ((enter["netsalary"].ToString()));
                discount_txt.Text = (enter["discount"].ToString());
                discountdetails_txt.Text = (enter["discountdetails"].ToString());
                bonus_txt.Text = (enter["bonus"].ToString());
                bonusdetails_txt.Text = ((enter["Bonusdetails"].ToString()));
            }
            con.Close();
        }


            private void Bexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpFns E = new EmpFns(label6.Text);
            E.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Bank con= new Bank(label6.Text);
            con.Show();
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void Bexit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EmpFns E = new EmpFns(label6.Text);
            E.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
