using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgConsoleApp6
{
    class AccBack : Papa
    {
        public static void MainAccBack()
        {
            #region
            string accessConfigDir = Path.Combine(dataPath, "ConfigDir");
            string dirOut = "";
            try { dirOut = File.ReadAllLines(Path.Combine(accessConfigDir, "PathBackUpAccessOut.txt"))[0]; }
            catch { Sos("Не могу прочитать", dataConfigDirPath + "PathBackUpAccessOut.txt"); }
            string[] storedDirs = File.ReadAllLines(Path.Combine(accessConfigDir, "PathBackUpAccessDirList.txt"));

            foreach (string dir in storedDirs)
            {
                ClonAccess(dir, dirOut);
            }
            return;
            #endregion
        }
    }
}

