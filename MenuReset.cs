using System;
class MenuReset : BaseProgram
{
    // static string[] MenuOptions;
    public MenuReset()
    {
	bencana = new Dictionary<string, string>();
                bencana.Add("aa", "ab");
                bencana.Add("ac", "ad");
                bencana.Add("ae", "af");


                 bool doreapet = false;


                do

                {


                    Console.WriteLine("apakah anda ingin mereset ?(Y/N)");

                    string jawaban = Console.ReadLine();
                    jawaban = jawaban.ToUpper();

                    switch (jawaban)
                    {
                        case "Y":
                            doreapet = false;
                            break;
                        case "N":
                            return;

                        default:
                            doreapet = true;
                            Console.WriteLine("ulangi");

                            continue;


                    }
                }
                while (doreapet) ;
                bool selamat = false;
                do
                {

                    Console.WriteLine("Konfirmasi");
                    Console.WriteLine("Apakah anda yakin, ingin semua data ini direset ?(Y/N)");
                    string jawaban1 = Console.ReadLine();
                    jawaban1 = jawaban1.ToUpper();
                    switch (jawaban1)
                    {
                        case "Y":
                            selamat = false;
                            break;
                        case "N":
                            return;
                            
                           

                        default:

                            Console.WriteLine("Ulangi");
                            selamat = true;
                            continue;
                    }
                }

                
                while (selamat) ;

                foreach (KeyValuePair<string,string> data in bencana)
                {

                    Console.WriteLine($"{data.Key} : {data.Value}");

                }

               

                    Console.WriteLine("data sudah undifined");
                Console.WriteLine("Apakah anda ingin kembali ke menu utama ?(Y/N)");
                string mana = Console.ReadLine();
                mana = mana.ToUpper();
                switch (mana) 
                {
                    case "Y":
                        menu = true;
                        break;
                    case "N":
                        return;
                  
                    default:
                        Console.WriteLine("Ulangi");
                        menu = true;

                        continue;
                }


            }
            while (menu);

    }
}