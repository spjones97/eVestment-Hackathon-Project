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
    public partial class DeveloperForm : Form
    {
        DataBaseAccess dataBaseAccess = new DataBaseAccess();
        DataTable dataTable = new DataTable();
        public DeveloperForm()
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
            string firmName = txtFirmName.Text;
            string firmType = boxFirmType.Text;

            if (firmName.Equals(""))
            {
                MessageBox.Show("Please enter firm name");
            }
            else if (firmType.Equals(""))
            {
                MessageBox.Show("Please select firm type");
            }
            else if (firmType.Equals("Consultant"))
            {
                MessageBox.Show("You chose Consultant");
                dataBaseAccess.closeConn();
            }
            else if (firmType.Equals("Investor"))
            {
                string query = "SELECT * FROM Published.Firm WHERE FirmName='" + firmName + "'";
                dataBaseAccess.readDatathroughAdapter(query, dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    DataRow[] data = dataTable.Select();
                    MessageBox.Show("Firm GUID: " + data[0]["FirmGUID"].ToString() + " copied to clipboard");
                    Clipboard.SetText(data[0]["FirmGUID"].ToString());
                    dataBaseAccess.closeConn();
                }
                else
                {
                    MessageBox.Show("Firm name invalid.");
                }
            }
            else if (firmType.Equals("Manager"))
            {
                MessageBox.Show("You chose Manager");
                dataBaseAccess.closeConn();
            }
        }
    }
}
