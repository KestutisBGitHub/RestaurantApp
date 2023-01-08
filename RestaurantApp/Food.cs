using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        public static void PrintFoodList()
        {
            string fileContent = File.ReadAllText("Food.txt");
            var foodList = JsonSerializer.Deserialize<List<Food>>(fileContent);
            foreach(var item in foodList)
            {
                Console.WriteLine($"No: {item.ItemNo}, Name: {item.Name}, Price: {item.Price}");
            }
        }

    }


}
