using System;
class MenuReset : BaseProgram
{
    // static string[] MenuOptions;
    public MenuReset()
    {
        bool menu = false;
        do
        {

            Console.WriteLine("Data Yang Tersimpan");
            foreach (KeyValuePair<string, string> data in MainProgram.dataGunung)
            {

                Console.WriteLine($"{data.Key} = {data.Value}");

            }




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
                    case "":
                        continue;

                    default:
                        doreapet = true;
                        Console.WriteLine("ulangi");

                        continue;


                }
            }
            while (doreapet);
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


            while (selamat);

            MainProgram.dataGunung.Clear();
            MainProgram.dataGunung.Add("Undifined", "Undifined");
            Console.WriteLine(MainProgram.dataGunung["Undifined"]);






            bool mini = false;
            do
            {
                Console.WriteLine("data sudah undifined");
                Console.WriteLine("Apakah anda ingin kembali ke menu utama ?(Y/N)");
                string mana = Console.ReadLine();
                mana = mana.ToUpper();
                switch (mana)
                {
                    case "Y":

                        return;
                    case "N":
                        menu = true;

                        break;

                    default:
                        Console.WriteLine("Ulangi");
                        mini = true;

                        continue;



                }

            }
            while (mini);

        }
        while (menu);

    }
}