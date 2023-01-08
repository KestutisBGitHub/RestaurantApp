using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class MainApp
    {
        public void StartApp()
        {
            Console.WriteLine("Hello pick your options");
            LayerTop();

           

        }
        public void LayerTop()
        {
            Console.WriteLine("[1] - Table List");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[x] - End");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "1")
            {
                LayerTableList();
            }  else if (input == "9")
            {
                LayerTop();
            }
            else if (input == "x")
            {
                Console.WriteLine("Good bye!!!");
                return;
            }
            else
            {
                Console.WriteLine("no such option, repeat");
                LayerTop();
            }
                       
        }

            public void LayerTableList()
            {
                Console.WriteLine("[1] - Free tables");
                Console.WriteLine("[2] - Busy tables");
                Console.WriteLine("[9] - Back");
                Console.WriteLine("[0] - Back to top");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "1")
            {
                //print free table list
                LayerFreeTables();
            }
            else if (input == "2")
            {
                //print busy table list
                LayerBusyTables();
            }
            else if (input == "9" || input == "0")
            {
                LayerTop();
            } else
            {
                Console.WriteLine("no such option, repeat");
                LayerTableList();
            }
        }


       


        public void LayerFreeTables()
        {
            
            Console.WriteLine("[1] - Take table");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "1")
            {
                //change table status
                LayerBusyTables();
            }
            else if (input == "9")
            {
                LayerTableList();
            }
            else if (input == "0")
            {
                LayerTop();
            }
            else
            {
                Console.WriteLine("no such option, repeat");
                LayerFreeTables();
            }
        }

        public void LayerBusyTables()
        {
            Console.WriteLine("[1] - Release table");
            Console.WriteLine("[2] - Review order");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "1")
            {
                //check is bill paid
                //change table status
                //delete table order list
                
            }
            else if (input == "2")
            {
                //print order list
                LayerReviewOrder();
            }
            else if (input == "9")
            {
                LayerTableList();
            }
            else if (input == "0")
            {
                LayerTop();
            }
            else
            {
                Console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }

        public void LayerReviewOrder()
        {
            Console.WriteLine("[1] - Add order");
            Console.WriteLine("[2] - Checkout");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "1")
            {

                LayerFoodDrinks();
            }
            else if (input == "2")
            {

                LayerCheckout();
            }
            else if (input == "9")
            {
                LayerBusyTables();
            }
            else if (input == "0")
            {
                LayerTop();
            }
            else
            {
                Console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }
        public void LayerFoodDrinks()
        {
            Console.WriteLine("[1] - Food");
            Console.WriteLine("[2] - Drinks");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "1")
            {
                //print food list
                LayerAddRemove();
            }
            else if (input == "2")
            {
                //print Drink list
                LayerAddRemove();
            }
            else if (input == "9")
            {

                LayerReviewOrder();
            }
            else if (input == "0")
            {
                LayerTop();
            }
            else
            {
                Console.WriteLine("no such option, repeat");
                LayerFoodDrinks();
            }
        }
        public void LayerAddRemove()
        {
            Console.WriteLine("[1] - Add");
            Console.WriteLine("[2] - Remove");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "1")
            {
                //add to table order
            }
            else if (input == "2")
            {
                //remove from table order
            }
            else if (input == "9")
            {
                LayerFoodDrinks();
            }
            else if (input == "0")
            {
                LayerTop();
            }
            else
            {
                Console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }

        public void LayerCheckout()
        {
            Console.WriteLine("[1] - Paid");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "1")
            {
                //change paid status
            }
            else if (input == "9")
            {
                LayerReviewOrder();
            }
            else if (input == "0")
            {
                LayerTop();
            }
            else
            {
                Console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }

        public void LayerCheck()
        {
            Console.WriteLine("[1] - Print check");
            Console.WriteLine("[2] - Don't Print check");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "1")
            {
                //print check
            }
            else if (input == "2")
            {
                //dont print
            }
            else
            {
                Console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }

        public void LayerEmail()
        {
            Console.WriteLine("[1] - Email check");
            Console.WriteLine("[2] - Don't email check");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "1")
            {
                LayerEmailTo();
            }
            else if (input == "2")
            {
                LayerTop();
            }
            else
            {
                Console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }

        public void LayerEmailTo()
        {
            Console.WriteLine("Enter email");
            var layerEmailTo = Console.ReadLine();
            Console.WriteLine($"Check sent to email address:{layerEmailTo}");
        }

















        
    }
}
