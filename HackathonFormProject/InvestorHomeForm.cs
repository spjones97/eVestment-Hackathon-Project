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
    public partial class InvestorHomeForm : Form
    {
        DataBaseAccess dataBaseAccess = new DataBaseAccess();
        DataTable dataTable = new DataTable();
        public InvestorHomeForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInvestorSubmit_Click(object sender, EventArgs e)
        {
            string dataNeeded = boxInvestorDataNeeded.Text;

            if (dataNeeded.Equals(""))
            {
                MessageBox.Show("Please choose data needed.");
            }
            else if (dataNeeded.Equals("Firm ID"))
            {
                string firmName = txtInvestorFirmName.Text;
                string firmGUID = txtInvestorFirmGUID.Text;

                if (firmName.Equals("") && firmGUID.Equals(""))
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
                string firmName = txtInvestorFirmName.Text;
                string firmID = txtInvestorFirmID.Text;

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
            else if (dataNeeded.Equals("Firm Name"))
            {
                string firmID = txtInvestorFirmID.Text;
                string firmGUID = txtInvestorFirmGUID.Text;

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
            else if (dataNeeded.Equals("Is DOL"))
            {
                string firmName = txtInvestorFirmName.Text;
                string firmID = txtInvestorFirmID.Text;
                string firmGUID = txtInvestorFirmGUID.Text;

                if (firmName.Equals("") && firmID.Equals("") && firmGUID.Equals(""))
                {
                    MessageBox.Show("Please enter Firm Name, Firm ID, or Firm GUID for this information");
                }
                else if (!firmName.Equals(""))
                {
                    string query = "SELECT (IsDOL) FROM Published.Firm WHERE FirmName = '" + firmName + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        if (data[0]["IsDOL"].Equals("1"))
                        {
                            MessageBox.Show("This is a DOL Investor");
                        }
                        else
                        {
                            MessageBox.Show("This is NOT a DOL Investor");
                        }
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
                    string query = "SELECT (IsDOL) FROM Published.Firm WHERE FirmID = '" + firmID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        if (data[0]["IsDOL"].Equals("1"))
                        {
                            MessageBox.Show("This is a DOL Investor");
                        }
                        else
                        {
                            MessageBox.Show("This is NOT a DOL Investor");
                        }
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
                    string query = "SELECT (IsDOL) FROM Published.Firm WHERE FirmGUID = '" + firmGUID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        if (data[0]["IsDOL"].Equals("1"))
                        {
                            MessageBox.Show("This is a DOL Investor");
                        }
                        else
                        {
                            MessageBox.Show("This is NOT a DOL Investor");
                        }
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Firm GUID invalid");
                    }
                }
            }
            else if (dataNeeded.Equals("Firm Type ID"))
            {
                string firmName = txtInvestorFirmName.Text;
                string firmID = txtInvestorFirmID.Text;
                string firmGUID = txtInvestorFirmGUID.Text;

                if (firmName.Equals("") && firmID.Equals("") && firmGUID.Equals(""))
                {
                    MessageBox.Show("Please enter Firm Name, Firm ID, or Firm GUID for this information");
                }
                else if (!firmName.Equals(""))
                {
                    string query = "SELECT (FirmTypeID) FROM Published.Firm WHERE FirmName = '" + firmName + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Firm Type ID: " + data[0]["FirmTypeID"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["FirmTypeID"].ToString());
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
                    string query = "SELECT (FirmTypeID) FROM Published.Firm WHERE FirmID = '" + firmID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Firm Type ID: " + data[0]["FirmTypeID"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["FirmTypeID"].ToString());
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
                    string query = "SELECT (FirmTypeID) FROM Published.Firm WHERE FirmGUID = '" + firmGUID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Firm Type ID: " + data[0]["FirmTypeID"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["FirmTypeID"].ToString());
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm();
            home.Show();
        }
    }
}
