using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Invoice
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        public void InitData(string orderid, DateTime orderdate, string customer, string adderss, string postalcode, string city, string phone, List<OrderDetail> data)
        {
            pOrderID.Value = orderid;
            pDate.Value = orderdate.Date;
            pCustomerName.Value = customer;
            pAddress.Value = adderss;
            pPostalCode.Value = postalcode;
            pCity.Value = city;
            pPhone.Value = phone;
            objectDataSource1.DataSource = data;
        }
    }
}
