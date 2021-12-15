using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class HistoryProgram : BaseProgram
    {
        static string[] MenuHistori = { "Cek Semua", "Cek Khusus" };
        public HistoryProgram()
        {
            
            
            //Akses file.txt
           //string filepath = @"C:\\Users\\yohan\\source\\repos\\Tugas Akhir\\Tugas Akhir\\file.txt";
           
            bool repeat = false;
            
            do
            {
                ClearMenu();
                int menu = SelectingOption(MenuHistori);
                ClearMenu();

            
            
                if (menu == 0)
                {
                    foreach(var item in dataGunung)
                        Console.WriteLine(item);
                }

                else if(menu == 1)
                {
                    Console.WriteLine("Data yang tersedia : ");

                    foreach(var item in dataGunung)
                        Console.WriteLine(item.Key);
                    
                    string data = "Maaf, data belum diisi!";
                    do
                    {
                      Console.Write("Pukul berapa yang anda ingin cek? ");
                      Console.Write("Pukul : ");
                      string pencarian = Console.ReadLine();
                      foreach(string i in dataGunung.Keys)
                      {
                          if (i == pencarian)
                          {
                              data = dataGunung[i];
                              Console.WriteLine("Ini data dataGunung " + data);
                              
                              repeat = false;
                          }
                      } 
                      if (data == "Maaf, data belum diisi!" )
                      {
                          Console.WriteLine("Data tidak ditemukan, tolong Ulangi");
                          repeat = true;
                      }
                    }while(repeat);

                    Console.WriteLine(data);
                }

                bool repeat2 = false;

                do
                {
                     Console.WriteLine("Ingin melakukan pengecheckan lainnya? (y/n)");
                    string mengulangi = Console.ReadLine().ToLower();
                    if (mengulangi == "y")
                     {
                        repeat = true;
                        repeat2 = false;
                     }

                else if (mengulangi == "n")
                {
                    Console.WriteLine("Terima kasih telah menggunakan program ini.\nJangan lupa untuk mengecheck secara berkala!");
                    
                    repeat2 = false;
                }
                else
                {                   
                    Console.WriteLine("Hanya menerima masukan huruf y/n!!");
                    repeat2 = true;
                }
                }while(repeat2);
               
            }while(repeat);
            
                

        }
    }
