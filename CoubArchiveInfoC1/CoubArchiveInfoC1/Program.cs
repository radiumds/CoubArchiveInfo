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

        static void CoubList()
        {

        }
        static void Main(string[] args)
        {
            try
            {
               //Logger.Info("Nice");
                System.Console.ReadKey();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Some bad");


            }
        }
    }
}
