using System.IO;

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

        public void GetFiles()
        {
        }
    }
}
