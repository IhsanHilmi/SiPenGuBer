using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class HistoryProgram : BaseProgram
    {
        static string[] MenuHistori = { "Cek Semua", "Cek Khusus" };
        static void Main(string[] args)
        {
            var Jam = DateTime.Now;
            Console.WriteLine(Jam.ToString("H:m"));
            string waktu = Jam.ToString();
            
            //Akses file.txt
           //string filepath = @"C:\\Users\\yohan\\source\\repos\\Tugas Akhir\\Tugas Akhir\\file.txt";
           
            bool repeat = false;
            var dict = new Dictionary<string, string>();
            dict.Add("01", "ini 1");
            dict.Add("02", "ini 2");
            dict.Add("03", "ini 3");
            dict.Add("04", "ini 4");
                
            
            int menu = SelectingOption(MenuHistori);
            Console.Clear();

            
                if (menu == 0)
                {
                    foreach(var item in dict)
                        Console.WriteLine(item);
                }

                else if(menu == 1)
                {
                    Console.WriteLine("Data yang tersedia : ");

                    foreach(var item in dict)
                        Console.WriteLine(item.Key);
                    
                    string data = "Maaf, data belum diisi!";
                    do
                    {
                      Console.Write("Pukul berapa yang anda ingin cek? ");
                      Console.Write("Pukul : ");
                      string pencarian = Console.ReadLine().PadLeft(2, '0');
                      foreach(string i in dict.Keys)
                      {
                          if (i == pencarian)
                          {
                              data = dict[i];
                              Console.WriteLine("Ini data Dict " + data);
                              
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

                Console.WriteLine("Ingin melakukan pengecheckan lainnya? (y/n)");
                string mengulangi = Console.ReadLine().ToLower();
                if (mengulangi == "y")
                {
                    repeat = true;
                }

                else if (mengulangi == "n")
                {
                    Console.WriteLine("Terima kasih telah menggunakan program ini.\nJangan lupa untuk mengecheck secara berkala!");
                    repeat = false;

                }
                else
                {                   
                    Console.WriteLine("Hanya menerima masukan angka y/n!!");
                    repeat = true;
                }

        }
    }
