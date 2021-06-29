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
    public partial class logout_Message : Form
    {
        public logout_Message()
        {
            InitializeComponent();
        }

        private void logout_Message_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Firstpage con = new Firstpage();
            con.Show();
            this.Hide();

            
        }
    }
}
