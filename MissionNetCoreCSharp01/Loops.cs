using System;
using System.Collections.Generic;
using MissionNetCoreCSharp01.Models;

namespace MissionNetCoreCSharp01
{
    public class Loops
    {
        public Loops()
        {
            Console.WriteLine("Loops");
        }

        // Insert the odd numbers from list1 to oddNumbersList
        // Print the values of oddNumbersList
        // Use the Do While statement
        public void DoStatement()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var oddNumbersList = new List<int>();

        }

        // Compute sum of first n natural numbers
        // Print the value of the sum
        // Use the For Statement
        public void ForStatement()
        {
            var n = 10;
            var sum = 0;

        }

        // Print the name of the products included on the list
        // Use the foreach statement
        public void ForEachStatement()
        {
            var orderProducts = new List<Product>()
            {
                new Product() { Name = "Product A"},
                new Product() { Name = "Product B"},
                new Product() { Name = "Product C"}
            };

        }

        // Compute the sum of the first n natural numbers
        // Print the value of the sum
        // Use the While statement
        public void WhileStatement()
        {
            var i = 1;
            var sum = 0;

        }
    }
}