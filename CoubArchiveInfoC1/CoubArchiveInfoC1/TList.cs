using System.IO;
using System.Net;
using NLog;
using System;

namespace CoubArchiveInfoC1
{
    class TList
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public int current;
        public int length;
        string[] list;
        public TList(string path)
        {
            list = Directory.GetFiles(path);
            length = list.Length;
            current = 0;
            for (int i = 0; i < length; i++)
            {
                list[i] = Path.GetFileNameWithoutExtension(list[i]); 
            }
           
        }
        public TList()
        {
            list = null;
            current = 0;
            length = 0;

        }

        public void Next()
        {
            current++;
        }

        public string Cur()
        {
            return list[current];
        }
        public void GetFiles(string path, string name)
        {
            try
            {
                WebClient wcj = new WebClient();
                string remoteUri = "http://coub.com/api/v2/coubs/" + name;
                string fileName = "**dirname**\\json\\" + name + ".json";
                wcj.DownloadFile(remoteUri, fileName);
            }
            catch(Exception exg)
            {
                Logger.Info(exg, "This coub was deleted: http://coub.com/api/v2/coubs/"+name);
                File.Create("**dirname**\\" + name + ".json");
            }
        }
    }
}
