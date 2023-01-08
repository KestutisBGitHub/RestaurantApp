using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Order
    {

        public string TableNo { get; set; }
        public int TableSize { get; set; }
        public DateTime DateAndTime { get; set; }
        public decimal TotalToPay { get; set; }
        public string Name { get; set; }
        


        

        public Order(string tableNo, int tableSize, DateTime dateAndTime, decimal totalToPay, string name  )
        {
            TableNo = tableNo;
            TableSize = tableSize;
            DateAndTime = dateAndTime;
            TotalToPay = totalToPay;
            { Name = name; }

        }
    }
}
