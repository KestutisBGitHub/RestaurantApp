using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Tables
    {
        public string Number { get; set; }
        public int Size { get; set; }
        public bool Status { get; set; }

        public bool TableStatusChange()
        {
            if (Status)
            {
                return false;
            } else {
                return true;
            };

        }

    }
}
