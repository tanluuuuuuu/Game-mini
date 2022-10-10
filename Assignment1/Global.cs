using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Assignment1
{
    internal class Global
    {
        private static Global instance;

        public String Topic = "";
        public String FileSave = Path.Combine("..\\AppRanking.txt");
        public Dictionary<string, List<int>> resultDict = new Dictionary<string, List<int>>();

        public static Global Instance 
        {
            get { if (instance == null) instance = new Global(); return Global.instance; } 
            private set => Global.instance = value; 
        }

        Global()
        {
            Topic = "";
            if (!File.Exists(FileSave))
            {
                MessageBox.Show("Not exist");
                using (FileStream fs = File.Create(FileSave))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes("Fruit\n");
                    fs.Write(title, 0, title.Length);
                    title = new UTF8Encoding(true).GetBytes("0\n");
                    fs.Write(title, 0, title.Length);
                    title = new UTF8Encoding(true).GetBytes("15\n");
                    fs.Write(title, 0, title.Length);

                    title = new UTF8Encoding(true).GetBytes("Animal\n");
                    fs.Write(title, 0, title.Length);
                    title = new UTF8Encoding(true).GetBytes("0\n");
                    fs.Write(title, 0, title.Length);
                    title = new UTF8Encoding(true).GetBytes("15\n");
                    fs.Write(title, 0, title.Length);

                    title = new UTF8Encoding(true).GetBytes("Vehicle\n");
                    fs.Write(title, 0, title.Length);
                    title = new UTF8Encoding(true).GetBytes("0\n");
                    fs.Write(title, 0, title.Length);
                    title = new UTF8Encoding(true).GetBytes("15\n");
                    fs.Write(title, 0, title.Length);

                    title = new UTF8Encoding(true).GetBytes("Sport\n");
                    fs.Write(title, 0, title.Length);
                    title = new UTF8Encoding(true).GetBytes("0\n");
                    fs.Write(title, 0, title.Length);
                    title = new UTF8Encoding(true).GetBytes("15\n");
                    fs.Write(title, 0, title.Length);
                }                
            }
            string[] lines = System.IO.File.ReadAllLines(FileSave);
            string key = "";
            int value = 0, maxValue = 15;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i % 3 == 0)
                    key = lines[i];
                else if (i % 3 == 1)
                    value = Int32.Parse(lines[1]);
                else if (i % 3 == 2)
                {
                    maxValue = Int32.Parse(lines[2]);
                    resultDict[key] = new List<int>() { value, maxValue };
                }
            }
        }
    }
}
