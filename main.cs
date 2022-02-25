using System;
using System.Collections.Generic;
using System.IO;

class Program {
    static void Main(string[] args) {   
      
      while(true){
            Console.WriteLine("Aralarina virgul koyarak isimleri yazin.");
            Console.Write("Giris: ");
            string text = Console.ReadLine();
            string[] split = text.Split(',');
      
                Random rnd = new Random();
                int index = rnd.Next(split.Length);
                Console.WriteLine($"Name: {split[index]}");                      
                    while(true){
                        Console.WriteLine("Devam edilsin mi? Y/N");
                         string bitir = Console.ReadLine();
                            if(bitir=="Y"){
                                     break;                     
                                }
                                else if(bitir=="N"){
                                      Console.WriteLine("Program sonlandiriliyor...");
                                      break;
                                }
                                else {
                                     continue; 
                                }
                      }
                            
        }
            Console.WriteLine("Yine bekleriz...");
    }
}

/*string text;   
          var fileStream = new FileStream(@"c:\oku.txt", FileMode.Open, FileAccess.Read);
          using (var streamReader = new StreamReader(fileStream))
          {
              text = streamReader.ReadToEnd();
          }*/

