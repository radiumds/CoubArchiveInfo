using System.IO;
using System.Net;

namespace CoubArchiveInfoC1
{
    class TList
    {
        private int current;
        public int length;
        string[] list;
        public TList(string path)
        {
            list = Directory.GetFiles(path);
            length = list.Length;
            current = 0;
            for (int i = 0; i < length; i++)
            {
                list[i] = list[i].Split('.')[0]; 
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
            WebClient wcj = new WebClient();
            string remoteUri = "http://coub.com/api/v2/coubs/"+name;
            string fileName = "D:\\CurrentDir\\Coubs\\radiumds\\json\\"+name+".json";
            wcj.DownloadFile(remoteUri, fileName);
        }
    }
}
