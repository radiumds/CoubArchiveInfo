using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using NLog;

namespace CoubArchiveInfoC1
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private 

        static void Main(string[] args)
        {
            try
            {
               //Logger.Info("Nice");
                System.Console.ReadKey();
                TList coub = new TList("D:\\CurrentDir\\Coubs\\radiumds");
                TList json = new TList("D:\\CurrentDir\\Coubs\\radiumds\\json");
                if (coub.length > json.length)
                {
                    
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Some bad");


            }
        }
    }
}
