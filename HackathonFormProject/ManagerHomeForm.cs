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
    public partial class ManagerHomeForm : Form
    {
        DataBaseAccess dataBaseAccess = new DataBaseAccess();
        DataTable dataTable = new DataTable();
        public ManagerHomeForm()
        {
            InitializeComponent();
        }

        private void btnInvestorSubmit_Click(object sender, EventArgs e)
        {
            string dataNeeded = boxManagerDataNeeded.Text;
            
            if (dataNeeded.Equals(""))
            {
                MessageBox.Show("Please choose Data Needed.");
            }
            else if (dataNeeded.Equals("Firm Name"))
            {
                string firmID = txtManagerFirmID.Text;
                string firmGUID = txtManagerFirmGUID.Text;

                if (firmID.Equals("") && firmGUID.Equals(""))
                {
                    MessageBox.Show("Please enter Firm ID or Firm GUID for this information");
                }
                else if (!firmID.Equals(""))
                {
                    string query = "SELECT (FirmName) FROM Published.Firm WHERE FirmID = '" + firmID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Firm Name: " + data[0]["FirmName"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["FirmName"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Firm ID invalid");
                    }
                }
                else if (!firmGUID.Equals(""))
                {
                    string query = "SELECT (FirmName) FROM Published.Firm WHERE FirmGUID = '" + firmGUID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Firm Name: " + data[0]["FirmName"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["FirmName"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Firm GUID invalid");
                    }
                }
            }
            else if (dataNeeded.Equals("Firm ID"))
            {
                string firmName = txtManagerFirmName.Text;
                string firmGUID = txtManagerFirmGUID.Text;

                if (firmGUID.Equals("") && firmName.Equals(""))
                {
                    MessageBox.Show("Please enter Firm Name or Firm GUID for this information");
                }
                else if (!firmName.Equals(""))
                {
                    string query = "SELECT (FirmID) FROM Published.Firm WHERE FirmName = '" + firmName + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Firm ID: " + data[0]["FirmID"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["FirmID"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Firm Name invalid");
                    }
                }
                else if (!firmGUID.Equals(""))
                {
                    string query = "SELECT (FirmID) FROM Published.Firm WHERE FirmGUID = '" + firmGUID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Firm ID: " + data[0]["FirmID"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["FirmID"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Firm GUID invalid");
                    }
                }
            }
            else if (dataNeeded.Equals("Firm GUID"))
            {
                string firmName = txtManagerFirmName.Text;
                string firmID = txtManagerFirmID.Text;

                if (firmName.Equals("") && firmID.Equals(""))
                {
                    MessageBox.Show("Please enter Firm Name or Firm ID for this information");
                }
                else if (!firmName.Equals(""))
                {
                    string query = "SELECT (FirmGUID) FROM Published.Firm WHERE FirmName = '" + firmName + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Firm GUID: " + data[0]["FirmGUID"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["FirmGUID"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Firm Name invalid");
                    }
                }
                else if (!firmID.Equals(""))
                {
                    string query = "SELECT (FirmGUID) FROM Published.Firm WHERE FirmID = '" + firmID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Firm GUID: " + data[0]["FirmGUID"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["FirmGUID"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Firm ID invalid");
                    }
                }
            }
            else if (dataNeeded.Equals("Website"))
            {
                string firmName = txtManagerFirmName.Text;
                string firmID = txtManagerFirmID.Text;
                string firmGUID = txtManagerFirmGUID.Text;

                if (firmName.Equals("") && firmID.Equals("") && firmGUID.Equals(""))
                {
                    MessageBox.Show("Please enter Firm Name, Firm ID, or Firm GUID for this information");
                }
                else if (!firmName.Equals(""))
                {
                    string query = "SELECT (Website) FROM Published.Firm WHERE FirmName = '" + firmName + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Website: " + data[0]["Website"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["Website"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Firm Name invalid");
                    }
                }
                else if (!firmID.Equals(""))
                {
                    string query = "SELECT (Website) FROM Published.Firm WHERE FirmID = '" + firmID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Website: " + data[0]["Website"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["Website"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Firm ID invalid");
                    }
                }
                else if (!firmGUID.Equals(""))
                {
                    string query = "SELECT (Website) FROM Published.Firm WHERE FirmGUID = '" + firmGUID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Website: " + data[0]["Website"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["Website"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Firm GUID invalid");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm();
            home.Show();
        }
    }
}
