using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace testcar
{
     public class classItems
     {

        public List<car> CarList { get; set; }
        public List<car> shoppingList { get; set; }

        public classItems()
            {
            CarList = new List<car>();
            shoppingList = new List<car>();
                
             }

      
        public decimal checkout()

        { 
            decimal totalSales = 0;

            foreach (var car in shoppingList)
            {
                totalSales += car.price;
            }
            shoppingList.Clear();
            return totalSales;
        }

    }
}
