using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    // DateEdit의 값을 DateTime으로 변환
                    DateTime fromDate = Convert.ToDateTime(DtFromDate.EditValue);
                    DateTime toDate = Convert.ToDateTime(DtToDate.EditValue);

                    string query = @"SELECT o.OrderID, c.CustomerID, c.ContactName, c.Address, c.PostalCode, c.City, c.Phone, o.OrderDate
                    FROM Orders o 
                    INNER JOIN Customers c ON o.CustomerID = c.CustomerID
                    WHERE o.OrderDate BETWEEN @FromDate AND @ToDate";

                    // Dapper의 매개변수 사용
                    var parameters = new { FromDate = fromDate, ToDate = toDate };
                    ordersBindingSource.DataSource = db.Query<Orders>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}
