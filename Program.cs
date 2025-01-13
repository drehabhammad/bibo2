using System.Reflection;
using System.Xml.Linq;
using System;
using testcar;

car car1 = new car(9200, 9525, "ford", "renu", 5000);
car car2 = new car(9200, 9525, "bmw", "son", 15000);
car car3 = new car(9200, 9525, "nissan", "ultra", 6000);

//Console.WriteLine(car1.name);

classItems s = new classItems();

s.shoppingList.Add(car1);
s.shoppingList.Add(car2);
s.shoppingList.Add(car3);

 decimal total = s.checkout();
Console.WriteLine(total);


Console.ReadLine();
