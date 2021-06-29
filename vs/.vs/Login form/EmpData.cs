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
    public partial class EmpData : Form
    {
        public EmpData(string str )
        {            
             InitializeComponent();
            textBox5.Text = str;
            SqlConnection con = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
             con.Open();
            string qry = "Select ID,Name,Bankname,Creditnumber,phone,Username,Password from [Employee] where Username='"+str+"' ";
            SqlCommand command = new SqlCommand(qry, con);
            SqlDataReader enter = command.ExecuteReader();
            if (enter.Read())
            {
                textBox1.Text = (enter["Name"].ToString());
                textBox2.Text = (enter["Bankname"].ToString());
                textBox3.Text = (enter["Creditnumber"].ToString());
                textBox4.Text = (enter["phone"].ToString());
                textBox6.Text = ((enter["Password"].ToString()));
                label8.Text = ((enter["ID"].ToString()));
            }
            con.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EmpFns Ee = new EmpFns(textBox5.Text);
            Ee.Show();
           this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EmpData_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection coon = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
            coon.Open();
            string update_query = @" update Employee Set Name='" + textBox1.Text + "', Bankname='" + textBox2.Text + "', Creditnumber='" + textBox3.Text + "', phone='" + textBox4.Text + "' , Username='" + textBox5.Text + "',Password='" + textBox6.Text + "' where ID='" + label8.Text + "' ";
            SqlCommand command = new SqlCommand(update_query, coon);
            command.ExecuteNonQuery();
            coon.Close();
            MessageBox.Show("Updated");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}
