using System;
using System.Collections.Generic;
using System.IO;

class Program {
    static void Main(string[] args) {
        using(var reader = new StreamReader(@"C:\test.csv")) {
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
    
                listA.Add(values[0]);
                listB.Add(values[1]);
            }
         }
    }
}
  
  
  var random = new Random();
         var list = new List<string>{"one","two","three","four"};
         int index = random.Next(list.Count);
         Console.WriteLine(list[index]);