using System;
class MenuCekStatus : BaseProgram
{
    // static string[] MenuOptions;
    public MenuCekStatus()
    {
          {
            IDictionary<string, string> dataGunung = new Dictionary<string, string>();

            bool checkerProgram = true;
            do
            {

            string magnitudoGempa, suhu, kelembaban, awanPanas, gasBerbahaya, laharLetusan, lava, lontaranBatuPijar, hujanAbu, jam;
            string status, pesan = "";

            var waktu = DateTime.Now; 
            Console.WriteLine("waktu saat ini: "+ waktu.ToString("h:m"));

                {
                    bool checkerPertanyaan = false;
                    
                    Console.WriteLine("Silakan masukkan jam!");
                    jam = (Console.ReadLine());
                    
                   // do
                    //{
                        Console.WriteLine("Silakan masukkan magnitudo gempa!");
                        magnitudoGempa = (Console.ReadLine());
                    //} while(checkerPertanyaan);

                    do
                    {
                        Console.WriteLine("apakah ada awan panas? (ya/tidak)");
                        awanPanas = Console.ReadLine().ToLower();
                        checkerPertanyaan = true;
                        switch (awanPanas)
                        {
                            case "ya":
                            case "tidak":
                                checkerPertanyaan = false;
                                break;

                            default:
                                checkerPertanyaan = true;
                                Console.WriteLine("jawaban tidak sesuai, silakan coba lagi!");
                                Console.WriteLine();
                                break;
                        }
                    } while (checkerPertanyaan);


                    Console.WriteLine("Silakan masukkan suhu!");
                    suhu = (Console.ReadLine());

                    Console.WriteLine("Silakan masukkan persen kelembaban! (skala 0-35)");
                    kelembaban = (Console.ReadLine());

                    do
                    {
                        Console.WriteLine("apakah ada gas berbahaya? (ya/tidak)");
                        gasBerbahaya = Console.ReadLine().ToLower();
                        checkerPertanyaan = true;
                        switch (gasBerbahaya)
                        {
                            case "ya":
                            case "tidak":
                                checkerPertanyaan = false;
                                break;

                            default:
                                checkerPertanyaan = true;
                                Console.WriteLine("jawaban tidak sesuai, silakan coba lagi!");
                                Console.WriteLine();
                                break;
                        }
                    } while (checkerPertanyaan);

                    do
                    {
                        Console.WriteLine("apakah ada lahar letusan? (ya/tidak)");
                        laharLetusan = Console.ReadLine().ToLower();
                        checkerPertanyaan = true;
                        switch (laharLetusan)
                        {
                            case "ya":
                            case "tidak":
                                checkerPertanyaan = false;
                                break;

                            default:
                                checkerPertanyaan = true;
                                Console.WriteLine("jawaban tidak sesuai, silakan coba lagi!");
                                Console.WriteLine();
                                break;
                        }
                    } while (checkerPertanyaan);

                    do
                    {
                        Console.WriteLine("apakah ada lava? (ya/tidak)");
                        lava = Console.ReadLine().ToLower();
                        checkerPertanyaan = true;
                        switch (lava)
                        {
                            case "ya":
                            case "tidak":
                                checkerPertanyaan = false;
                                break;

                            default:
                                checkerPertanyaan = true;
                                Console.WriteLine("jawaban tidak sesuai, silakan coba lagi!");
                                Console.WriteLine();
                                break;
                        }
                    } while (checkerPertanyaan);

                    do
                    {
                        Console.WriteLine("apakah ada lontaran batu pijar? (ya/tidak)");
                        lontaranBatuPijar = Console.ReadLine().ToLower();
                        checkerPertanyaan = true;
                        switch (lontaranBatuPijar)
                        {
                            case "ya":
                            case "tidak":
                                checkerPertanyaan = false;
                                break;

                            default:
                                checkerPertanyaan = true;
                                Console.WriteLine("jawaban tidak sesuai, silakan coba lagi!");
                                Console.WriteLine();
                                break;
                        }
                    } while (checkerPertanyaan) ;

                    do
                    {
                        Console.WriteLine("apakah ada hujan abu? (ya/tidak)");
                        hujanAbu = Console.ReadLine().ToLower();
                        checkerPertanyaan = true;
                        switch (hujanAbu)
                        {
                            case "ya":
                            case "tidak":
                                checkerPertanyaan = false;
                                break;

                            default:
                                checkerPertanyaan = true;
                                Console.WriteLine("jawaban tidak sesuai, silakan coba lagi!");
                                Console.WriteLine();
                                break;
                        }
                    } while (checkerPertanyaan);

                    {
                        if ((Convert.ToDouble(magnitudoGempa) < 2.9 && awanPanas == "tidak" && (Convert.ToDouble(suhu) >= 0 && (Convert.ToDouble(suhu) <= 32)) &&
                       (Convert.ToDouble(kelembaban) >= 15 && (Convert.ToDouble(kelembaban) <= 35)) &&
                        gasBerbahaya == "tidak" && laharLetusan == "tidak" && lava == "tidak" && lontaranBatuPijar == "tidak" &&
                        hujanAbu == "tidak"))
                        {
                            status = "NORMAL_Level_I";
                        }
                        else if ((Convert.ToDouble(magnitudoGempa) >= 2.9 && (Convert.ToDouble(magnitudoGempa) <= 3.9)) && awanPanas == "ya" &&
                            (Convert.ToDouble(suhu) >= 33) && (Convert.ToDouble(suhu) <= 37) &&
                            (Convert.ToDouble(kelembaban) >= 10) && (Convert.ToDouble(kelembaban) <= 14) && gasBerbahaya == "ya" && laharLetusan == "tidak" &&
                            lava == "tidak" && lontaranBatuPijar == "tidak" && hujanAbu == "tidak")
                        {
                            status = "WASPADA_Level_II";
                            pesan = "Perlu disiapkan masker sebanyak penduduk yang ada";
                        }
                        else if ((Convert.ToDouble(magnitudoGempa) >= 4.0) && (Convert.ToDouble(magnitudoGempa) <= 5.2) && awanPanas == "ya" &&
                            (Convert.ToDouble(suhu) >= 38) && (Convert.ToDouble(suhu) <= 40) &&
                            (Convert.ToDouble(kelembaban) >= 5) && (Convert.ToDouble(kelembaban) <= 9) && gasBerbahaya == "ya" && laharLetusan == "tidak" &&
                            lava == "tidak" && lontaranBatuPijar == "ya" && hujanAbu == "ya")
                        {
                            status = "SIAGA_Level_III";
                            pesan = "Perlu disiapkan masker sebanyak 3 kali lipat dari jumlah penduduk penduduk yang ada, alat radio panggil sebanyak " +
                                    "desa yang ada, dan evakuasi warga di radius < 6 KM dari gunung";
                        }
                        else if ((Convert.ToDouble(magnitudoGempa) >= 5.2) && awanPanas == "ya" && (Convert.ToDouble(suhu) >= 40) &&
                            (Convert.ToDouble(kelembaban) >= 0) && (Convert.ToDouble(kelembaban) <= 4) && gasBerbahaya == "ya" && laharLetusan == "ya" &&
                            lava == "ya" && lontaranBatuPijar == "ya" && hujanAbu == "ya")
                        {
                            status = "AWAS_Level_IV";
                            pesan = "Perlu disiapkan masker sebanyak 6 kali lipat dari jumlah penduduk penduduk yang ada, alat radio panggil sebanyak " +
                                    "desa yang ada, dan evakuasi warga di radius < 10 KM dari gunung";
                        }
                        else
                        {
                            status = "masukan_tidak_sesuai_sehingga_status_tidak_bisa_muncul";
                        }                                    
                    }
                } 
                
                    Console.WriteLine();
                    Console.Write(magnitudoGempa + ";" + awanPanas + ";" + suhu + ";" + kelembaban + ";" + gasBerbahaya + ";" + laharLetusan + ";" + lava
                    + ";" + lontaranBatuPijar + ";" + hujanAbu + ";" + status + ";");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(pesan);
                    Console.WriteLine();

                    dataGunung.Add(jam, magnitudoGempa + ";" + awanPanas + ";" + suhu + ";" + kelembaban + ";" + gasBerbahaya + ";" + laharLetusan + ";" + lava
                    + ";" + lontaranBatuPijar + ";" + hujanAbu + ";" + status + ";");
                     Console.WriteLine(dataGunung[jam]);

                bool checkPerulanganProgram = true;
                while (checkPerulanganProgram)
                {
                    Console.WriteLine("apakah anda ingin lanjut ? (Y/N)");
                    string jawaban = Console.ReadLine();
                    jawaban = jawaban.ToUpper();
                    Console.WriteLine();

                    switch (jawaban)
                    {
                        case "Y":
                            checkPerulanganProgram = false;
                            checkerProgram = true;
                            break;

                        case "N":
                            checkPerulanganProgram = false;
                            checkerProgram = false;
                            break;

                        default:
                            checkPerulanganProgram = true;
                            break;
                    }
                } 
            } while (checkerProgram);
          }   
    }
}