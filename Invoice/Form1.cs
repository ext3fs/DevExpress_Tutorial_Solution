using Dapper;
using DevExpress.XtraEditors;
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
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime oneMonthAgo = today.AddMonths(-1);

            DtFromDate.DateTime = oneMonthAgo;
            DtToDate.DateTime = today;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Orders obj = ordersBindingSource.Current as Orders;
            if (obj == null)
                return;

            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query = @"SELECT d.OrderID, p.ProductName, d.Quantity, d.Discount, d.UnitPrice
                    FROM [Order Details] d 
                    INNER JOIN Products p ON d.ProductID = p.ProductID
                    WHERE d.OrderID = @OrderID";

                    // Dapper의 매개변수 사용
                    var parameters = new { OrderID = obj.OrderId };
                    var list = db.Query<OrderDetail>(query, parameters).ToList();

                    using (var frm = new XfrmPrint())
                    {
                        frm.PrintInvoice(obj, list);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
