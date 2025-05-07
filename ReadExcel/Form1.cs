using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace ReadExcel
{
    public partial class Form1 : Form
    {
        DataTableCollection tableCollection;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TxtFileName.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });

                            tableCollection = ds.Tables;
                            CbxSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                CbxSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[CbxSheet.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if (dt == null)
                return;

            List<Customer> customers = new List<Customer>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Customer customer = new Customer();
                customer.CustomerID = dt.Rows[i]["CustomerID"].ToString();
                customer.CompanyName = dt.Rows[i]["CompanyName"].ToString();
                customer.ContactName = dt.Rows[i]["ContactName"].ToString();
                customer.ContactTitle = dt.Rows[i]["ContactTitle"].ToString();
                customer.Address = dt.Rows[i]["Address"].ToString();
                customer.City = dt.Rows[i]["City"].ToString();
                customer.Region = dt.Rows[i]["Region"].ToString();
                customer.PostalCode = dt.Rows[i]["PostalCode"].ToString();
                customer.Country = dt.Rows[i]["Country"].ToString();
                customer.Phone = dt.Rows[i]["Phone"].ToString();
                customer.Fax = dt.Rows[i]["Fax"].ToString();
                customers.Add(customer);
            }
            customerBindingSource.DataSource = customers;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DapperPlusManager.Entity<Customer>().Table("Customers");
                List<Customer> customers = customerBindingSource.DataSource as List<Customer>;
                if (customers != null)
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        db.BulkInsert(customers);
                    }
                }
                MessageBox.Show("insert success!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
