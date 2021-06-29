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
    public partial class PenaltyBonus : Form
    {
        public PenaltyBonus()
        {
            InitializeComponent();
        }

        private void Bupdate_Click(object sender, EventArgs e)
        {
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            system_fn ss = new system_fn();
            ss.Show();
        }

        private void PenaltyBonus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.update();
        }
       
        void update()
        {
            SqlConnection con = new SqlConnection("Data Source=WIN10PRO1809OFF\\SQLEXPRESS;Initial Catalog=Employementsystem;Integrated Security=True");
            con.Open();
            List<int> EmployeeID = new List<int>();
            //List 7aga zay el array f c# 
            SqlCommand cmd = new SqlCommand("Select * from [dbo].[GetEmployeeID]()", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                EmployeeID.Add(Convert.ToInt32( rdr.GetValue(0)));       
            }
           
            long count = EmployeeID.LongCount();//3dad el employees
            rdr.Close();
            //now hnbtdy n5azen
            string date = textBox4.Text;
            for (int i=0; i<count;i++)
            {
                int CurrentSalary, Bonus, Discount, NetSalary;
                
                SqlCommand cd = new SqlCommand("Select [dbo].[GetDiscount](@EmployeeID ,@DiscountDate )", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID[i]));
                cd.Parameters.Add(new SqlParameter("@DiscountDate", date));
                cd.ExecuteNonQuery();
                
                Discount =Convert.ToInt32( cd.ExecuteScalar() );

                SqlCommand ccd = new SqlCommand("Select [dbo].[GetBonus](@EmployeeID ,@BonusDate )", con);
                ccd.CommandType = CommandType.Text;
                ccd.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID[i]));
                ccd.Parameters.Add(new SqlParameter("@BonusDate ", date));
                ccd.ExecuteNonQuery();
                Bonus = Convert.ToInt32(ccd.ExecuteScalar());

                SqlCommand cdd = new SqlCommand("Select [dbo].[GetCurrentSalary](@EmployeeID ,@SalaryDate )", con);
                cdd.CommandType = CommandType.Text;
                cdd.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID[i]));
                cdd.Parameters.Add(new SqlParameter("@SalaryDate ", date));
                cdd.ExecuteNonQuery();
                CurrentSalary = Convert.ToInt32(cdd.ExecuteScalar());

                NetSalary = Bonus + CurrentSalary - Discount;

                string update= "Update Employee Set netsalary='"+NetSalary.ToString()+"' Where ID='"+EmployeeID[i].ToString()+"'";
                SqlCommand c = new SqlCommand(update);
                c.Connection = con;
                c.ExecuteNonQuery();
                MessageBox.Show("Updated");
                //thats it
            }
            con.Close();

        }
    }
}
