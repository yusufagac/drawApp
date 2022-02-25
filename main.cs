using System;
using System.Collections.Generic;
using System.IO;

class Program {
    static void Main(string[] args) {   
          string text;   
          var fileStream = new FileStream(@"c:\oku.txt", FileMode.Open, FileAccess.Read);
          using (var streamReader = new StreamReader(fileStream))
          {
              text = streamReader.ReadToEnd();
          }
    
            string[] split = text.Split(',');
      
                Random rnd = new Random();
                int index = rnd.Next(split.Length);
                Console.WriteLine($"Name: {split[index]}");                    
    }
}

