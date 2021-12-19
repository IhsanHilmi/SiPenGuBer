using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HistoryProgram : BaseProgram
{
    static string[] menuHistori = { "Cek Semua", "Cek Khusus", "Kembali" };
    public HistoryProgram()
    {


        //Akses file.txt
        //string filepath = @"C:\\Users\\yohan\\source\\repos\\Tugas Akhir\\Tugas Akhir\\file.txt";

        bool repeat = false;

        do
        {
            ClearMenu();
            int menu = SelectingOption(menuHistori);
            ClearMenu();



            if (menu == 0)
            {
                foreach (var item in MainProgram.dataGunung)
                    Console.WriteLine(item);
            }

            else if (menu == 1)
            {
                Console.WriteLine("Data yang tersedia : ");

                foreach (var item in MainProgram.dataGunung)
                    Console.WriteLine(item.Key);

                string data = "Maaf, data belum diisi!";
                do
                {
                    string pencarian = CekInputJam("Pukul berapa yang anda ingin cek?\nPukul :  ");

                    foreach (string i in MainProgram.dataGunung.Keys)
                    {
                        if (i == pencarian)
                        {
                            data = MainProgram.dataGunung[i];
                            Console.WriteLine(i + " " + data);

                            repeat = false;
                        }
                    }
                    if (data == "Maaf, data belum diisi!")
                    {
                        Console.WriteLine("Data tidak ditemukan, tolong Ulangi");
                        repeat = true;
                    }
                } while (repeat);
            }
            else
            {
                return;
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
            } while (repeat2);

        } while (repeat);



    }
}
