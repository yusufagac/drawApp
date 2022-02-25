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
                break;
                            
        }
            Console.WriteLine("Yine bekleriz...");
    }
}