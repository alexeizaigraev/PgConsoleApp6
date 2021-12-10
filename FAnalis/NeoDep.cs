﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgConsoleApp6
{
    internal class NeoDep : PgBase
    {

        internal static List<string> neoDeps = new List<string>();

        public static bool flag = true;

        private static List<List<string>> futur = new List<List<string>>();
        private static List<List<string>> actual = new List<List<string>>();

        private static List<string> futurList = new List<string>();
        private static List<string> actualList = new List<string>();

        public static void MkNeoDep()
        {
            info = "";
            neoDeps = new List<string>();
            futur = new List<List<string>>();
            actual = new List<List<string>>();

            futurList = new List<string>();
            actualList = new List<string>();

            futur = DepGet();
            actual = DepGetNew();

            futurList = GetListDep();
            actualList = GetListDepNew();

            foreach (var fut in futur)
            {
                var depFut = fut[0];
                foreach (var act in actual)
                {
                    var depAct = act[0];
                    if (depFut == depAct)
                    {
                        FindDifrent(fut, act);
                    }
                }
            }

            info += "\n\n";
            FindAbcentDeps();
            info += "\n\n";

            //if (flag) info = "Всё совпало\n";
            info += "\n\t Анализ завершён";
            string ofname = "info.txt";
            TextToFile(ofname, info);
            OpenNote(ofname);
        }




        private static void FindDifrent(List<string> fut, List<string> act)
        {
            int colNum = 14;
            bool equalFlag = true;
            if (!fut[colNum].Equals(act[colNum]))
            {
                var dep = fut[0].Substring(0, 7);
                if (neoDeps.IndexOf(dep) < 0) neoDeps.Add(dep);
            }
            if (!equalFlag) info += "\n";
        }

        private static void FindAbcentDeps()
        {
            foreach (var fufu in futurList)
            {
                int ind = actualList.IndexOf(fufu);
                if (ind < 0)
                {
                    var dep = fufu.Substring(0, 7);
                    if (neoDeps.IndexOf(dep) < 0) neoDeps.Add(dep);
                }
            }

        }
    }
}
