using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_UI
{
    class SalesData
    {
        private double quantity1;
        private double income;
        private DateTime date;

        public SalesData(double quantity, double total_income, DateTime date_of_sale) {
            this.quantity = quantity;
            this.total_income = total_income;
            this.date_of_sale = date_of_sale;
        }

        public double quantity { get; set; }

        public double total_income { get; set; }

        public DateTime date_of_sale { get; set; }
    }
}
