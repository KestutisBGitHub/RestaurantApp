using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Tables
    {
        
        public string TableNo { get; set; }
        public int Size { get; set; }
        public bool Status { get; set; }



        public Tables(string tableNo, int size, bool status)
        {
            TableNo = tableNo;
            Size = size;
            Status = status;
        }
        public static void PrintTableList (string input)
        {
            string fileContent = File.ReadAllText("Tables.txt");
            var tableList = JsonSerializer.Deserialize<List<Tables>>(fileContent);
                
                
                

                if (input == "1")
                { 
                  var trueList = tableList.Where(x => x.Status == true);
                  foreach (var table in trueList)
                {

                    Console.WriteLine($"Table No: {table.TableNo}, Size: {table.Size}, Status: {table.Status}");
                }                                       
                } else if (input == "2")
                {
                var trueList = tableList.Where(x => x.Status == false);
                foreach (var table in trueList)
                {
                    Console.WriteLine($"Table No: {table.TableNo}, Size: {table.Size}, Status: {table.Status}");
                }
            }
            
            
        }

      public static void TableStatusChange(string input)
       {
            string fileContent = File.ReadAllText("Tables.txt");
            var tableList = JsonSerializer.Deserialize<List<Tables>>(fileContent);

            var change = tableList.First(x => x.TableNo == input);

            if (change.Status)
            {
                change.Status = false;
            } else
            {
                change.Status = true;
            }
            var jsonString = JsonSerializer.Serialize(tableList);
            File.WriteAllText("tables.txt", jsonString);
     }





    }
}
