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
    public partial class login_screen : Form
    {
        public login_screen()
        {
            
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_txt_Enter(object sender, EventArgs e)
        {
            username_txt.Text = "";
        }

        private void password_txt_Enter(object sender, EventArgs e)
        {
            password_txt.Text = "";
        }

        private void password_txt_Leave(object sender, EventArgs e)
        {
           
        }

        private void username_txt_Leave(object sender, EventArgs e)
        {
            
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txt.Text == "")
            {
                emptyUsername con = new emptyUsername();
                con.ShowDialog();
                username_txt.Focus(); 
            }
            else if (password_txt.Text == "")
            {
                Empty_password con = new Empty_password();
                con.ShowDialog();
                password_txt.Focus();
            }
            else if((username_txt.Text=="admin"|| username_txt.Text == "Admin")&& (password_txt.Text == "admin" || password_txt.Text == "Admin"))
            {
                this.Hide();
                system_fn s = new system_fn();
                s.Show();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string qry = "Select Count(*) from Employee where Username ='" + username_txt.Text + "' and Password='" + password_txt.Text + "'  ";

                SqlCommand command = new SqlCommand(qry, con);
                int result = Convert.ToInt32(command.ExecuteScalar());
                  if (result > 0)
                  {
                      
                   this.Hide();
                   EmpFns co = new EmpFns(username_txt.Text);
                    co.Show();                   
                       
                  }
                  else
                  {
                        Invalid_message x = new Invalid_message();
                        x.ShowDialog();
                  }

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Firstpage con = new Firstpage();
            con.Show();
        }

    }
}
