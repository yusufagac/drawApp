using System;
using System.Collections.Generic;
using System.IO;

class Program {
    static void Main(string[] args) {
        using(var reader = new List<string>{"one","two","three","four"}; {
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
        var random = new Random();
        int index = random.Next(listA.Count);
        Console.WriteLine(listA[index]);
    }
}
  
  
  
        // var list = new List<string>{"one","two","three","four"};
        // using(var reader = new StreamReader(@"C:\test.csv"))