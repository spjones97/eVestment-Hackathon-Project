using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonFormProject
{
    public partial class HomeForm : Form
    {
        DataBaseAccess dataBaseAccess = new DataBaseAccess();
        DataTable dataTable = new DataTable();
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmSubmit_Click(object sender, EventArgs e)
        {
            string firmType = boxFirmType.Text;
            
            if (firmType.Equals(""))
            {
                MessageBox.Show("Please choose firm type.");
            }
            else if (firmType.Equals("Consultant"))
            {
                this.Hide();
                ConsultantHomeForm consultantForm = new ConsultantHomeForm();
                consultantForm.Show();
            }
            else if (firmType.Equals("Investor"))
            {
                this.Hide();
                InvestorHomeForm investorForm = new InvestorHomeForm();
                investorForm.Show();
            }
            else if (firmType.Equals("Manager"))
            {
                this.Hide();
                ManagerHomeForm managerForm = new ManagerHomeForm();
                managerForm.Show();
            }
        }
    }
}
