using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class XfrmPrint : DevExpress.XtraEditors.XtraForm
    {
        public XfrmPrint()
        {
            InitializeComponent();
        }

        public void PrintInvoice(Orders order, List<OrderDetail> data)
        {
            var report = new XtraReport1();
            //foreach (var p in report.Parameters)
            //    p.Visible = false;
            report.InitData(order.OrderId.ToString(), order.OrderDate, order.CustomerId, order.Address, order.PostalCode, order.City, order.Phone, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}