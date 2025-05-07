using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.BLL
{
    class OrderDetail
    {
        public int OrderId { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public Decimal DisCount { get; set; }
        [Display(Name = "Unit Price")]
        public Decimal UnitPrice { get; set; }
        public Decimal Total
        {
            get
            {
                return Quantity * UnitPrice - Quantity * UnitPrice * DisCount;
            } 
        }

    }
}
