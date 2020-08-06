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
    public partial class ConsultantHomeForm : Form
    {
        DataBaseAccess dataBaseAccess = new DataBaseAccess();
        DataTable dataTable = new DataTable();
        public ConsultantHomeForm()
        {
            InitializeComponent();
        }

        private void btnInvestorSubmit_Click(object sender, EventArgs e)
        {
            string dataNeeded = boxConsultantDataNeeded.Text;

            if (dataNeeded.Equals(""))
            {
                MessageBox.Show("Please choose data needed.");
            }
            else if (dataNeeded.Equals("Consultant Name"))
            {
                string firmID = txtConsultantFirmID.Text;
                string firmGUID = txtConsultantFirmGUID.Text;

                if (firmID.Equals("") && firmGUID.Equals(""))
                {
                    MessageBox.Show("Please enter Firm ID or Firm GUID for this information");
                }
                else if (!firmID.Equals(""))
                {
                    string query = "SELECT (ConsultantName) FROM Published.FirmConsultantData WHERE FirmId = '" + firmID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Consultant Name: " + data[0]["ConsultantName"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["ConsultantName"].ToString());
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
                string consultantName = txtConsultantName.Text;
                string firmGUID = txtConsultantFirmGUID.Text;

                if (consultantName.Equals("") && firmGUID.Equals(""))
                {
                    MessageBox.Show("Please enter Consultant Name or Firm GUID for this information");
                }
                else if (!consultantName.Equals(""))
                {
                    string query = "SELECT (FirmId) FROM Published.FirmConsultantData WHERE ConsultantName = '" + consultantName + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Firm ID: " + data[0]["FirmId"].ToString() + " copied to clipboard");
                        Clipboard.SetText(data[0]["FirmId"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Consultant Name invalid");
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
                string consultantName = txtConsultantName.Text;
                string firmID = txtConsultantFirmID.Text;

                if (consultantName.Equals("") && firmID.Equals(""))
                {
                    MessageBox.Show("Please enter Consultant Name or Firm ID for this information");
                }
                else if (!consultantName.Equals(""))
                {
                    string query = "SELECT (FirmGUID) FROM Published.Firm WHERE FirmName = '" + consultantName + "'";
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
                        MessageBox.Show("Consultant Name invalid");
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
            else if (dataNeeded.Equals("Client Count"))
            {
                string consultantName = txtConsultantName.Text;
                string firmID = txtConsultantFirmID.Text;
                string firmGUID = txtConsultantFirmGUID.Text;

                if (firmID.Equals("") && firmGUID.Equals(""))
                {
                    MessageBox.Show("Please enter Firm ID or Firm GUID for this information");
                }
                else if (!consultantName.Equals(""))
                {
                    string query = "SELECT (TotalClientCount) FROM Published.FirmConsultantData WHERE ConsultantName = '" + consultantName + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Client Count: " + data[0]["TotalClientCount"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Consultant Name invalid");
                    }
                }
                else if (!firmID.Equals(""))
                {
                    string query = "SELECT (TotalClientCount) FROM Published.FirmConsultantData WHERE FirmId = '" + firmID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Client Count: " + data[0]["TotalClientCount"].ToString());
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
                    string dummyQuery = "SELECT (FirmID) FROM Published.Firm WHERE FirmGUID = '" + firmGUID + "'";
                    dataBaseAccess.readDatathroughAdapter(dummyQuery, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] dummyData = dataTable.Select();
                        string dummyID = dummyData[0]["FirmID"].ToString();

                        dataBaseAccess.closeConn();
                        dataTable = new DataTable();

                        string query = "SELECT (TotalClientCount) FROM Published.FirmConsultantData WHERE FirmId = '" + dummyID + "'";
                        dataBaseAccess.readDatathroughAdapter(query, dataTable);

                        if (dataTable.Rows.Count == 1)
                        {
                            DataRow[] data = dataTable.Select();
                            MessageBox.Show("Client Count: " + data[0]["TotalClientCount"].ToString());
                            dataTable = new DataTable();
                            dataBaseAccess.closeConn();
                        }
                        else
                        {
                            MessageBox.Show("Firm GUID invalid");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Firm GUID invalid");
                    }
                }
            }
            else if (dataNeeded.Equals("Asset Count"))
            {
                string consultantName = txtConsultantName.Text;
                string firmID = txtConsultantFirmID.Text;
                string firmGUID = txtConsultantFirmGUID.Text;

                if (consultantName.Equals("") && firmID.Equals("") && firmGUID.Equals(""))
                {
                    MessageBox.Show("Please enter Firm ID or Firm GUID for this information");
                }
                else if (!consultantName.Equals(""))
                {
                    string query = "SELECT (TotalAssets) FROM Published.FirmConsultantData WHERE ConsultantName = '" + consultantName + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Asset Count: " + data[0]["TotalAssets"].ToString());
                        dataTable = new DataTable();
                        dataBaseAccess.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Consultant Name invalid");
                    }
                }
                else if (!firmID.Equals(""))
                {
                    string query = "SELECT (TotalAssets) FROM Published.FirmConsultantData WHERE FirmId = '" + firmID + "'";
                    dataBaseAccess.readDatathroughAdapter(query, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] data = dataTable.Select();
                        MessageBox.Show("Asset Count: " + data[0]["TotalAssets"].ToString());
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
                    string dummyQuery = "SELECT (FirmID) FROM Published.Firm WHERE FirmGUID = '" + firmGUID + "'";
                    dataBaseAccess.readDatathroughAdapter(dummyQuery, dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow[] dummyData = dataTable.Select();
                        string dummyID = dummyData[0]["FirmID"].ToString();

                        dataBaseAccess.closeConn();
                        dataTable = new DataTable();

                        string query = "SELECT (TotalClientCount) FROM Published.FirmConsultantData WHERE FirmId = '" + dummyID + "'";
                        dataBaseAccess.readDatathroughAdapter(query, dataTable);

                        if (dataTable.Rows.Count == 1)
                        {
                            DataRow[] data = dataTable.Select();
                            MessageBox.Show("Asset Count: " + data[0]["TotalAssets"].ToString());
                            dataTable = new DataTable();
                            dataBaseAccess.closeConn();
                        }
                        else
                        {
                            MessageBox.Show("Firm GUID invalid");
                        }
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
