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
    public partial class Update_delete : Form
    {
        public Update_delete()
        {
            InitializeComponent();
           
        }     

        private void Update_delete_Load(object sender, EventArgs e)
        {
            showDGV();
        }
        public void showDGV()
        {
            SqlConnection con = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
            con.Open();
            string query = "Select ID,Name,Username, Password,Departement_ID from Employee ";
            SqlCommand command = new SqlCommand(query, con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(table);
            dataGridView.DataSource = table;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            system_fn con = new system_fn();
            con.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            ID_lbl.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            Name_lbl.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            Username_txt.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            password_txt.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            Departement_txt.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection coon = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
            coon.Open();
            string updateqry = " Update Employee SET Username='"+Username_txt.Text+"', Password='"+password_txt.Text+"', Departement_ID='"+Departement_txt.Text+"' WHERE ID ="+int.Parse(ID_lbl.Text);
            SqlCommand command = new SqlCommand(updateqry, coon);
            command.ExecuteNonQuery();
            coon.Close();
            MessageBox.Show("Updated");
            showDGV();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            SqlConnection coon = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
            coon.Open();
            string deleteqry2 = " Delete from Discount Where [Emp-id] = '" + ID_lbl.Text + "' Delete from Bonus Where ID ='" + ID_lbl.Text + "' Delete from Salary Where [Emp-id] = '" + ID_lbl.Text + "' Delete from Employee Where ID ='" + ID_lbl.Text + "'" ;
            SqlCommand cmd = new SqlCommand(deleteqry2, coon);
            cmd.ExecuteNonQuery();
            coon.Close();
            MessageBox.Show("Deleted");
            showDGV();
            //string deleteqry3 = " Delete from Bonus Where ID =" + int.Parse(ID_lbl.Text);
            //SqlCommand cmd2 = new SqlCommand(deleteqry2, coon);
            //string deleteqry4 = " Delete from Salary Where [Emp-id] =" + int.Parse(ID_lbl.Text);
            //SqlCommand cmd3 = new SqlCommand(deleteqry2, coon);
            //string deleteqry = " Delete from Employee Where ID =" + int.Parse(ID_lbl.Text);
            //SqlCommand cmd4 = new SqlCommand(deleteqry2, coon);
            //cmd1.ExecuteNonQuery();
            //cmd2.ExecuteNonQuery();
            //cmd3.ExecuteNonQuery();
            
        }
    }
}
