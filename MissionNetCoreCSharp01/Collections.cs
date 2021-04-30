using System;
using System.Collections.Generic;
using System.Linq;
using MissionNetCoreCSharp01.Models;

namespace MissionNetCoreCSharp01
{
    public class Collections
    {
        public Collections()
        {
            Console.WriteLine("Collections");
        }

        // Print the name of the products included on the productsDictionary
        // Use the dictionary key to get the Product names
        public void DictionaryCollection()
        {
            var productsDictionary = new Dictionary<string, Product>()
            {
                {"1", new Product() { Code = "1", Name = "Keyboard"} },
                {"2", new Product() { Code = "2", Name = "Mouse"} },
                {"3", new Product() { Code = "3", Name = "Screen"} }
            };
        }

        public void GenericListCollection()
        {

        }
    }
}
