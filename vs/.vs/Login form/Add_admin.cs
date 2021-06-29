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
    public partial class Add_admin : Form
    {
        public Add_admin()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (Empid_txt.Text == " "||name_txt.Text == "" || username_txt.Text == "" || Password_txt.Text == "" || depID_txt.Text == "" || Phone_txt.Text == "" || Experience_txt.Text == "" || Bankname_txt.Text == "" || credit_txt.Text == "" || Expirydate_txt.Text == "" || salarydate_txt.Text == "" || netsalary_txt.Text == "" || discount_txt.Text == "" || bonus_txt.Text == "")
            {
                MessageBox.Show("Please enter a valid data");
                Add_admin coon = new Add_admin();
                coon.Show();
            }
            else
            { 
            SqlConnection con = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
                con.Open();
            string query = "INSERT INTO Employee (ID,Name,Username,Password,[Departement_ID],phone,Experienceyears,Bankname,Creditnumber,Expirydate) VALUES('"+Empid_txt.Text+"','" + name_txt.Text + "','" + username_txt.Text + "','" + Password_txt.Text + "','" + depID_txt.Text + "','" + Phone_txt.Text + "','" + Experience_txt.Text + "','" + Bankname_txt.Text + "','" + credit_txt.Text + "','" + Expirydate_txt.Text + "') INSERT INTO Salary([Emp-id],salarydate,Currentsalary) Values('"+Empid_txt.Text+"','" + salarydate_txt.Text + "','" + netsalary_txt.Text + "') INSERT INTO Bonus(ID,bonusdate,bonus) VALUES('"+Empid_txt.Text+"','" + salarydate_txt.Text + "','" + bonus_txt.Text + "')INSERT INTO Discount([Emp-id],discountdate,discount) VALUES('"+Empid_txt.Text+"','" + salarydate_txt.Text + "','" + discount_txt.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
                con.Close();
            MessageBox.Show("Inserted Successfully");
            Empid_txt.Text = " ";
            name_txt.Text = " ";
            username_txt.Text = " ";
            Password_txt.Text = " ";
            depID_txt.Text = " ";
            Phone_txt.Text = " ";
            Experience_txt.Text = " ";
            Bankname_txt.Text = " ";
            credit_txt.Text = " ";
            Expirydate_txt.Text = " ";
            salarydate_txt.Text = " ";
            netsalary_txt.Text = " ";
            discount_txt.Text = " ";
            bonus_txt.Text = " ";
        }
           
        }

        private void label1_Click_1(object sender, EventArgs e)
            {

            }

            private void textBox7_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox6_TextChanged(object sender, EventArgs e)
            {

            }

            private void label8_Click(object sender, EventArgs e)
            {

            }

            private void label9_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click_1(object sender, EventArgs e)
            {

            }

            private void button1_Click_2(object sender, EventArgs e)
            {
                system_fn con = new system_fn();
                con.Show();
                this.Hide();
            }

            private void textBox1_TextChanged_1(object sender, EventArgs e)
            {

            }

            private void textBox5_TextChanged_1(object sender, EventArgs e)
            {

            }

            private void textBox7_TextChanged_1(object sender, EventArgs e)
            {

            }

            private void textBox6_TextChanged_1(object sender, EventArgs e)
            {

            }

            private void textBox8_TextChanged(object sender, EventArgs e)
            {

            }

        private void depID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

