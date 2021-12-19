using System;
class MenuCekStatus : BaseProgram
{
    static string[] menuCekStatusOptions = { "Mulai Penginputan Status", "Kembali" };
    public MenuCekStatus()
    {

        int menu = SelectingOption(menuCekStatusOptions);
        switch (menu)
        {
            case 1: return;
            case 0:
            default: break;
        }

        bool checkerProgram = true;
        do
        {

            string magnitudoGempa, suhu, kelembaban, awanPanas, gasBerbahaya, laharLetusan, lava, lontaranBatuPijar, hujanAbu, jam;
            string status, pesan = "";

            var waktu = DateTime.Now;
            Console.WriteLine("waktu saat ini: " + waktu.ToString("H:m"));

            jam = CekInputJam("Silakan masukkan jam pengecekan gunung ! (jam:menit)");

            Console.WriteLine("=====================================");

            magnitudoGempa = Convert.ToString(PertanyaanKondisiDouble("Silakan masukkan magnitudo gempa!"));

            awanPanas = (PertanyaanKondisiString("apakah ada gas berbahaya? (ya/tidak)"));

            suhu = Convert.ToString(PertanyaanKondisiDouble("silakan masukan suhu!"));

            kelembaban = Convert.ToString(PertanyaanKondisiDouble("Silakan masukkan persen kelembaban! (skala 0-35)"));

            gasBerbahaya = (PertanyaanKondisiString("apakah ada gas berbahaya? (ya/tidak)"));

            laharLetusan = (PertanyaanKondisiString("apakah ada lahar letusan? (ya/tidak)"));

            lava = (PertanyaanKondisiString("apakah ada lava? (ya/tidak)"));

            lontaranBatuPijar = (PertanyaanKondisiString("apakah ada lontaran batu pijar? (ya/tidak)"));

            hujanAbu = (PertanyaanKondisiString("apakah ada hujan abu? (ya/tidak)"));

            // method clearmenu
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

            Console.WriteLine();
            Console.Write(jam + ";" + magnitudoGempa + ";" + awanPanas + ";" + suhu + ";" + kelembaban + ";" + gasBerbahaya + ";" + laharLetusan + ";" + lava
                      + ";" + lontaranBatuPijar + ";" + hujanAbu + ";" + status + ";");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(pesan);
            Console.WriteLine();

            MainProgram.dataGunung.Add(jam, magnitudoGempa + ";" + awanPanas + ";" + suhu + ";" + kelembaban + ";" + gasBerbahaya + ";" + laharLetusan + ";" +
                lava + ";" + lontaranBatuPijar + ";" + hujanAbu + ";" + status + ";");
            Console.WriteLine(MainProgram.dataGunung[jam]);

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
    static string PertanyaanKondisiString(string pertanyaan)
    {
        string jawaban;
        bool CheckerPertanyaan = false;
        do
        {
            Console.WriteLine(pertanyaan);
            jawaban = Console.ReadLine().ToLower();
            Console.WriteLine("=====================================");
            switch (jawaban)
            {
                case "ya":
                case "tidak":
                    CheckerPertanyaan = false;
                    break;
                default:
                    CheckerPertanyaan = true;
                    Console.WriteLine("Silakan masukan input yang sesuai!");
                    break;
            }
        } while (CheckerPertanyaan);
        return jawaban;
    }

    static double PertanyaanKondisiDouble(string pertanyaan)
    {
        double dobb;
        bool isADouble = false;
        do
        {
            Console.WriteLine(pertanyaan);
            isADouble = double.TryParse(Console.ReadLine(), out dobb);
            Console.WriteLine("=====================================");


            if (!isADouble)
            {
                Console.WriteLine("Silakan masukan input yang sesuai!");
            }

        } while (!isADouble);
        return dobb;
    }
}