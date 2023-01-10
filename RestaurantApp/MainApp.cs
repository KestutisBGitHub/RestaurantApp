using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class MainApp
    {
        private string _tableNumberForApp;
        private IConsole _console;
        public void StartApp(IConsole console)
        {
            _console = console;
            _console.WriteLine("Hello pick your options");
            LayerTop();

           

        }
        public void LayerTop()
        {
            _console.WriteLine("[1] - Table List");
            _console.WriteLine("[9] - Back");
            _console.WriteLine("[x] - End");
            var input = _console.ReadLine();
            _console.WriteLine(input);
            if (input == "1")
            {
                LayerTableList();
            }  else if (input == "9")
            {
                LayerTop();
            }
            else if (input == "x")
            {
                _console.WriteLine("Good bye!!!");
                return;
            }
            else
            {
                _console.WriteLine("no such option, repeat");
                LayerTop();
            }
                       
        }

            public void LayerTableList()
            {
            _console.WriteLine("[1] - Free tables");
            _console.WriteLine("[2] - Busy tables");
            _console.WriteLine("[9] - Back");
            _console.WriteLine("[0] - Back to top");
            var input = _console.ReadLine();
            _console.WriteLine(input);
            if (input == "1")
            {
                
                Tables.PrintTableList(input);
                LayerFreeTables();
            }
            else if (input == "2")
            {
                
                Tables.PrintTableList(input);
                LayerBusyTables();
            }
            else if (input == "9" || input == "0")
            {
                LayerTop();
            } else
            {
                _console.WriteLine("no such option, repeat");
                LayerTableList();
            }
        }


       


        public void LayerFreeTables()
        {

            _console.WriteLine("[1] - Take table, enter table number");
            _console.WriteLine("[9] - Back");
            _console.WriteLine("[0] - Back to top");
            var input = Console.ReadLine().Split(" ");
            _console.WriteLine(input[0]);
            if (input[0] == "1")
            {
                _tableNumberForApp=input[1];
                Tables.TableStatusChange(input[1]);
                LayerBusyTables();
            }
            else if (input[0] == "9")
            {
                LayerTableList();
            }
            else if (input[0] == "0")
            {
                LayerTop();
            }
            else
            {
                _console.WriteLine("no such option, repeat");
                LayerFreeTables();
            }
        }

        public void LayerBusyTables()
        {
            _console.WriteLine("[1] - Release table, enter table number");
            _console.WriteLine("[2] - Review order");
            _console.WriteLine("[9] - Back");
            _console.WriteLine("[0] - Back to top");
            var input = _console.ReadLine().Split(" ");
            
            if (input[0] == "1")
            {

                _tableNumberForApp = input[1];

                Tables.TableStatusChange(input[1]);
                LayerTableList();

            }
            else if (input[0] == "2")
            {
                _tableNumberForApp = input[1];
                Order.OrderView(_tableNumberForApp);
                
                LayerReviewOrder();
            }
            else if (input[0] == "9")
            {
                LayerTableList();
            }
            else if (input[0] == "0")
            {
                LayerTop();
            }
            else
            {
                _console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }

        public void LayerReviewOrder()
        {
            _console.WriteLine("[1] - Add order");
            _console.WriteLine("[2] - Checkout");
            _console.WriteLine("[9] - Back");
            _console.WriteLine("[0] - Back to top");
            var input = _console.ReadLine();
            _console.WriteLine(input);
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
                _console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }
        public void LayerFoodDrinks()
        {
            _console.WriteLine("[1] - Food");
            _console.WriteLine("[2] - Drinks");
            _console.WriteLine("[9] - Back");
            _console.WriteLine("[0] - Back to top");
            var input = _console.ReadLine();
            _console.WriteLine(input);
            if (input == "1")
            {
                Food.PrintFoodList();
                LayerAddRemove();
            }
            else if (input == "2")
            {
                Drinks.PrintDrinkList();
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
                _console.WriteLine("no such option, repeat");
                LayerFoodDrinks();
            }
        }
        public void LayerAddRemove()
        {
            _console.WriteLine("[1] - Add and enter dish number");
            _console.WriteLine("[2] - Remove and enter dish number");
            _console.WriteLine("[9] - Back");
            _console.WriteLine("[0] - Back to top");
            var input = _console.ReadLine().Split(" ");
            _console.WriteLine($"{input[1]} {input[0]}");
            if (input[0] == "1")
            {
                //add to table order
            }
            else if (input[0] == "2")
            {
                //remove from table order
            }
            else if (input[0] == "9")
            {
                LayerFoodDrinks();
            }
            else if (input[0] == "0")
            {
                LayerTop();
            }
            else
            {
                _console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }

        public void LayerCheckout()
        {
            _console.WriteLine("[1] - Paid");
            _console.WriteLine("[9] - Back");
            _console.WriteLine("[0] - Back to top");
            var input = _console.ReadLine();
            _console.WriteLine(input);
            if (input == "1")
            {
                

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
                _console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }

        public void LayerCheck()
        {
            _console.WriteLine("[1] - Print check");
            _console.WriteLine("[2] - Don't Print check");
            var input = _console.ReadLine();
            _console.WriteLine(input);
            if (input == "1")
            {
                //print check
                //delete table order list
            }
            else if (input == "2")
            {
                //dont print
                //delete table order list
            }
            else
            {
                _console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }

        public void LayerEmail()
        {
            _console.WriteLine("[1] - Email check");
            _console.WriteLine("[2] - Don't email check");
            var input = _console.ReadLine();
            _console.WriteLine(input);
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
                _console.WriteLine("no such option, repeat");
                LayerBusyTables();
            }
        }

        public void LayerEmailTo()
        {
            _console.WriteLine("Enter email");
            var layerEmailTo = _console.ReadLine();
            _console.WriteLine($"Check sent to email address:{layerEmailTo}");
        }

















        
    }
}
