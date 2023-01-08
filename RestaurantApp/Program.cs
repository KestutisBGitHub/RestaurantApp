namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello pick your options");
            
            Console.WriteLine("[1] - Table List");
            Console.WriteLine("[2] - Menu");
            Console.WriteLine("[9] - Back");
            var layerTop = Console.ReadLine();

            
            Console.WriteLine("[1] - Free tables");
            Console.WriteLine("[2] - Busy tables");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var layerTableList = Console.ReadLine();

            
            Console.WriteLine("[1] - Take table");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var layerFreeTables = Console.ReadLine();

            
            Console.WriteLine("[1] - Release table");
            Console.WriteLine("[2] - Review order");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var layerBusyTables = Console.ReadLine();

            
            Console.WriteLine("[1] - Add order");
            Console.WriteLine("[2] - Checkout");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var layerReviewOrder = Console.ReadLine();

            
            Console.WriteLine("[1] - Food");
            Console.WriteLine("[2] - Drinks");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var layerFoodDrinks = Console.ReadLine();

            
            Console.WriteLine("[1] - Add");
            Console.WriteLine("[2] - Remove");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var layerAddRemove = Console.ReadLine();

            
            Console.WriteLine("[1] - Paid");
            Console.WriteLine("[9] - Back");
            Console.WriteLine("[0] - Back to top");
            var layerCheckout = Console.ReadLine();

            
            Console.WriteLine("[1] - Print check");
            Console.WriteLine("[2] - Don't Print check");
            var layerCheck = Console.ReadLine();

            
            Console.WriteLine("[1] - Email check");
            Console.WriteLine("[2] - Don't email check");
            var layerEmail = Console.ReadLine();

            
            Console.WriteLine("Enter email");
            var layerEmailTo = Console.ReadLine();

            

        }
    }
}