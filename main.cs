using System;
using System.Collections.Generic;
using System.IO;

class Program {
    static void Main(string[] args) { 
      //Baska bir sistemde tekrar dene...
      /*string text;   
          var fileStream = new FileStream(@"c:\oku.txt", FileMode.Open, FileAccess.Read);
          using (var streamReader = new StreamReader(fileStream))
          {
              text = streamReader.ReadToEnd();
          }*/
    
       while(true){
            Console.WriteLine("Aralarina virgul koyarak isimleri yazin.");
            Console.Write("Giris: ");
            string text = Console.ReadLine();
            string[] split = text.Split(',');
      
                Random rnd = new Random();
                int index = rnd.Next(split.Length);
                Console.WriteLine($"Name: {split[index]}");                      
                        Console.WriteLine("Devam edilsin mi? Y/N");
                         string devam = Console.ReadLine();
                            if(devam=="Y"){
                                     continue;                     
                                }
                                else {
                                      Console.WriteLine("Program sonlandiriliyor...");
                                      break;
                                }
                           
        }
            Console.WriteLine("Yine bekleriz...");
    }
}