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
    public partial class Rank : Form
    {
        public Rank(string user)
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(" Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True ");
            label1.Text = user;
        }

        private void Rank_Load(object sender, EventArgs e)
        {
      
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Firstpage con = new Firstpage();
            con.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                SqlConnection con = new SqlConnection(" Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True ");
                con.Open();
                string update_query = @" update Employee Set Rate='" + textBox1.Text + "' where Username='" + label1.Text + "' ";
                SqlCommand command = new SqlCommand(update_query, con);
                command.ExecuteNonQuery();
                Firstpage coon = new Firstpage();
                coon.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("please enter your rate ");
                EmpFns c = new EmpFns(label1.Text);
                c.Show();
                Rank x = new Rank(label1.Text);
                x.Show();
            }


            //    con.Open();
            //string insertStr = "INSERT INTO [Employee] (Rate) VALUES (@rate) where Username='"+label1.Text+"'";
            //SqlCommand command = new SqlCommand(insertStr, con);
            //SqlParameter paramrank = new SqlParameter("@rate",label1.Text);
            //command.Parameters.Add(paramrank);
            //command.ExecuteNonQuery();
            //Firstpage coon = new Firstpage();
            //coon.Show();
            //this.Hide();

            //con.Close();
            //string query = "INSERT INTO Employee (Rate) VALUES('"+textBox1.Text+"') where Username='"+ label1.Text+ "'";
            //SqlCommand command = new SqlCommand(query, con);
            //command.ExecuteNonQuery();
            //con.Close();
            //Firstpage coon = new Firstpage();
            //coon.Show();
            //this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
