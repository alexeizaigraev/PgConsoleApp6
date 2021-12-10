using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PgConsoleApp6
{
    class Program
    {


        /// <summary>
        /// ClearScreen
        /// </summary>
        public static void ClearScreen()
        {
            #region #ClearScreen
            Console.Clear();
            Console.WriteLine();
            #endregion
        }

        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            #region #Main

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            //PgBase.TermFromFile();
            //PgBase.OtborFromFile();
            //PgBase.DepFromFile();
            //Console.ReadLine();
            //__________________

            /*
            Console.ForegroundColor = ConsoleColor.Black;
            string say = "";
            while (say != "123")
                say = Console.ReadLine();

            Console.WriteLine(" * C# designed by Alexei Zaigraev neya1969@gmail.com * ");
            */

            MenuMain();
            #endregion
        }

        /// <summary>
        /// Main Menu
        /// </summary>
        public static void MenuMain()
        {
            #region #MenuMain
            Console.Clear();
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("\t\t\t\t\t * C# Alexei Zaigraev neya1969@gmail.com * ");

            Papa.delegateMenuDict = new Dictionary<string, Papa.delegateMenu>
            {
                { "People", new Papa.delegateMenu(MenuPeople) },
                { "Some", new Papa.delegateMenu(MenuSome) },
                { "Monitor", new Papa.delegateMenu(MenuMonitor) },
                { "Kabinet", new Papa.delegateMenu(MenuKabinet) },
                { "DataBase", new Papa.delegateMenu(MenuPg) }
                
            };
            do
            {
                Papa.MkMenu(Papa.delegateMenuDict);
            } while (true);
            #endregion
        }

        /// <summary>
        /// MenuPeople
        /// </summary>
        protected static void MenuPeople()
        {
            #region #MenuPeople
            Console.Clear();
            Papa.delegateMenuDict = new Dictionary<string, Papa.delegateMenu>
            {
                { "Priem", new Papa.delegateMenu(Priem.MainPriem) },
                { "Otpusk", new Papa.delegateMenu(Otpusk.MainOtpusk)},
                { "Perevod", new Papa.delegateMenu(Perevod.MainPerevod)},
                { "PostAll", new Papa.delegateMenu(PostAll.MainPostAll)}
            };
            do { Papa.MkMenu(Papa.delegateMenuDict); } while (true);
            #endregion
        }





        /// <summary>
        /// MenuSome
        /// </summary>
        protected static void MenuSome()
        {
            #region #MenuSome
            Console.Clear();
            Papa.delegateMenuDict = new Dictionary<string, Papa.delegateMenu>
            {
                { "Terminals", new Papa.delegateMenu(Term.MainTerm) },
                {"Summury_Hr_Otbor", new Papa.delegateMenu(HrDepActual.MainHrDepActual) },
                { "Summury_AB", new Papa.delegateMenu(HrDepAbActual.MainHrDepAbActual)},
                //{ "Site_Regimes", new Papa.delegateMenu(SiteNewRegimes.MainSiteRegimes) },
                { "Site", new Papa.delegateMenu(SiteNewActual.MainSiteActual) },
                {"Natasha", new Papa.delegateMenu(NatashaActual.MainNatashaActual) }
                

                /*
                
                { "summury", new Papa.delegateMenu(HrDeps.MainHrDeps) },
                { 
                { "HrDepsAb", new Papa.delegateMenu(HrDepsAb.MainHrDepsAb)}
                */
            };
            do { Papa.MkMenu(Papa.delegateMenuDict, 3); } while (true);
            #endregion
        }



        /// <summary>
        /// MenuMonitor
        /// </summary>
        protected static void MenuMonitor()
        {
            #region #MenuMonitor
            Console.Clear();
            Papa.delegateMenuDict = new Dictionary<string, Papa.delegateMenu>
            {
                { "Walker", new Papa.delegateMenu(Rasklad.MainRasklad) },
                { "AccBack", new Papa.delegateMenu(AccBack.MainAccBack)},
                { "Monitor", new Papa.delegateMenu(Monitor.MainMonitor)},
                { "Get_RP_Otbor", new Papa.delegateMenu(GetRp.MainGetRp)},
                { "Get_RP_Agent", new Papa.delegateMenu(GetRpAll.MainGetRpAll)},
                { "Gnetz", new Papa.delegateMenu(Gnetz.MainGnetz)},
                { "GdrieBackUp", new Papa.delegateMenu(GdriveBackUp.MainGdriveBackUp)}
            };
            do { Papa.MkMenu(Papa.delegateMenuDict, 3); } while (true);
            #endregion
        }



        /// <summary>
        /// MenuKabinetMenuKabinet
        /// </summary>
        protected static void MenuKabinet()
        {
            #region
            Console.Clear();
            Papa.delegateMenuDict = new Dictionary<string, Papa.delegateMenu>
            {
                { "Rro", new Papa.delegateMenu(Rro.MainRro) },
                { "Pereezd", new Papa.delegateMenu(Pereezd.MainPereezd)},
                { "Otmena", new Papa.delegateMenu(Otmena.MainOtmena)},
                { "Prro", new Papa.delegateMenu(Prro.MainPrro)},
                { "Knigi", new Papa.delegateMenu(Knigi.MainKnigi)},
                { "Pereezd_New", new Papa.delegateMenu(PereezdNew.MainPereezd)}

            };
            do { Papa.MkMenu(Papa.delegateMenuDict); } while (true);
            #endregion
        }


        protected static void MenuPg()
        {
            #region #MenuOtbor
            Console.Clear();
            Papa.delegateMenuDict = new Dictionary<string, Papa.delegateMenu>
            {
                { "Refresh", new Papa.delegateMenu(ExternProcess.RefresFromAccessAll) },
                { "Otbor_From_To_Deps", new Papa.delegateMenu(Otbor.MainOtbor) },
                { "Otbor_List_Terminals", new Papa.delegateMenu(OtborHard.MainOtborHard)},
                { "Otbor_To_Actual", new Papa.delegateMenu(Actual.OtborToActual) },
                { "Refresh_Actual", new Papa.delegateMenu(Actual.RefreshActual)},
                { "Clear_Actual_Otbor", new Papa.delegateMenu(Actual.ClearActualOtbor)},
                { "Clear_Actual", new Papa.delegateMenu(Actual.ClearActual)},
                { "Analis", new Papa.delegateMenu(Analis.AnalizMain)},
                { "Show_Otbor", new Papa.delegateMenu(Show.Otbor)}
            };
            do { Papa.MkMenu(Papa.delegateMenuDict); } while (true);
            #endregion
        }



        #region #Color Print
        internal static void pRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(text);
        }

        internal static void pGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(text);
        }

        internal static void pYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
        }

        internal static void pGray(string text)
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(text);
        }

        internal static void pDarkGray(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(text);
        }

        internal static void pBlue(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
        }

        internal static void pDarkBlue(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(text);
        }

        internal static void pCyan(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(text);
        }
        protected static void pMagenta(string text)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(text);
        }
        #endregion
    }
}
