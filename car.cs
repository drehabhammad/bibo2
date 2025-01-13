using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcar
{
    public class car
    {
        public int id { get; set; }
        public int num { get; set; } 
        public string name { get; set; }
        public string model { get; set; }

        public int price { get; set; }

        public car(int id, int num, string name, string model, int price)
        {
            this.id = id;
            this.num = num;
            this.name = name;
            this.model = model;
            this.price = price;
        }
    }
}
