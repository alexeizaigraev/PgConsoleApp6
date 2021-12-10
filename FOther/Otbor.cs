﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PgConsoleApp6
{
    class Otbor : PgBase
    {
        public static void MainOtbor()
        {
            // PgBase.OtborCl();

            List<string[]> arr = new List<string[]>();
            string outText = "term;dep\n";
            SayYellow("\n Dep: From To:\n");
            string choise = Console.ReadLine();
            pBlue("\n__________\n");
            int start = 0;
            int finish = 0;
            if (choise.IndexOf(" ") > -1)
            {
                string[] choiseSplit = choise.Split(' ');
                if (choiseSplit[0].Length != 7 || choiseSplit[1].Length != 7) Sos("Bed dep", choise);
                start = Convert.ToInt32(choiseSplit[0]);
                finish = Convert.ToInt32(choiseSplit[1]);
            }
            else
            {
                if (choise.Length != 7) Sos("Bed dep", choise);
                start = Convert.ToInt32(choise);
                finish = start;
            }
            //int dep = 0;
            //int term = 0;
            string depStr = "";
            string termStr = "";
            string outLine = "";
            for (int x = start; x <= finish; x++)
            {
                depStr = x.ToString();
                termStr = (x * 10 + 1).ToString();
                outLine = termStr + ";" + depStr;
                arr.Add(outLine.Split(';'));

                pBlue(outLine);
                outText += outLine + "\n";
            }
            TextToFile(Path.Combine(dataInPath, "otbor.csv"), outText);

            PgBase.OtborAddChoise(arr);
        }

    }
}
