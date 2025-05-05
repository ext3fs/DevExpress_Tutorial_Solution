using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial1.BLL;
using Z.Dapper.Plus;

namespace Tutorial1
{
    public partial class ReadExcelToDB : Form
    {
        DataTableCollection tableCollection;

        public ReadExcelToDB()
        {
            InitializeComponent();
        }

        private void ReadExcelToDB_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'testDataSet.Customers' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.customersTableAdapter.Fill(this.testDataSet.Customers);

        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TextBoxFileName.Text = ofd.FileName;
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
                            ComboBoxExcelFileName.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                ComboBoxExcelFileName.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }
       
        private void ComboBoxExcelFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[ComboBoxExcelFileName.SelectedItem.ToString()];
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
            customersBindingSource.DataSource = customers;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = "Server=localhost;Database=test;User Id = ilyoung; Password=1234;";
                DapperPlusManager.Entity<Customer>().Table("Customers");
                List<Customer> customers = customersBindingSource.DataSource as List<Customer>;
                if (customers != null)
                {
                    using (IDbConnection db = new SqlConnection(connStr))
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
