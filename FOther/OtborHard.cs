using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PgConsoleApp6
{
    class OtborHard : PgBase
    {
        public static void MainOtborHard()
        {
            // PgBase.OtborCl();

            List<string[]> arr = new List<string[]>();


            bool flag = true;
            string outText = "term;dep\n";

            do
            {
                SayYellow("\n Terminals cross spaces:\n");
                string choise = Console.ReadLine();
                string[] choiseSplit = choise.Split(' ');
                if (choise.IndexOf(' ') < 0)
                {
                    while (choise.Length < 8)
                    {
                        Alarm("bed", choise);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" -> ");
                        choise = Console.ReadLine();
                    }
                    outText += choise + ";" + choise.Substring(0, 7) + "\n";
                    goto LabelMe;
                }

                foreach (string term in choiseSplit)
                {
                    string myTerm = term;
                    if (term.Length < 8)
                    {
                        Alarm("bed", term);
                        flag = false;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" -> ");
                            myTerm = Console.ReadLine();
                            if (myTerm.Length > 7) flag = true;
                        } while (!flag);
                    }
                    string dep = myTerm.Substring(0, 7);
                    outText += $"{myTerm};{dep}\n";
                }
            } while (!flag);




        LabelMe:


            TextToFile(Path.Combine(dataInPath, "otbor.csv"), outText);

            PgBase.OtborAddChoise(arr);
            SayGreen(outText);
        }

    }
}
