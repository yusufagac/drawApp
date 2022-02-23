using System;
using System.Collections.Generic;

class Program {
      static void Main(string[] args) {
         var random = new Random();
         var list = new List<string>{"one","two","three","four"};
         int index = random.Next(list.Count);
         Console.WriteLine(list[index]);
      }
   }
