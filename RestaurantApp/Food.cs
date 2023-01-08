﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Food
    {
        public string ItemNo { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        

        public Food(string itemNo, string name, decimal price)
        {
            ItemNo = itemNo;
            Name = name;
            Price = price;
        }


    }


}
