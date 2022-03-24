using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using NLog;
using System.Net;

namespace CoubArchiveInfoC1
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private static void Work()
        {
            string cpath = "D:\\CurrentDir\\Coubs\\radiumds";
            string jpath = "D:\\CurrentDir\\Coubs\\radiumds\\json";
            TList coub = new TList(cpath);
            TList json = new TList(jpath);
            if (coub.length > json.length)
            {
                if (json.Cur() == coub.Cur())
                {
                    json.Next();
                    coub.Next();
                }
                else
                {
                    json.GetFiles(jpath, coub.Cur());
                    coub.Next();
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
               //Logger.Info("Nice");
                System.Console.ReadKey();
                Work();
                WebClient test = new WebClient();
                string remoteUri = "http://coub.com/api/v2/coubs/30i5c9";
                string fileName = "D:\\CurrentDir\\Coubs\\radiumds\\json\\30i5c9.json";
                test.DownloadFile(remoteUri, fileName);


            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Some bad");


            }
        }
    }
}
