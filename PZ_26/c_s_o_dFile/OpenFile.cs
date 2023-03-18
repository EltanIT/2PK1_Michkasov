using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_26.c_s_o_dFile
{
    class OpenFile
    {

        private string getNameFile = "default";

        private string path;

        public OpenFile(string nameFile)
        {
            this.getNameFile = nameFile;
            path = "C:\\" + getNameFile + ".txt";
        }

        
       
        public string openFile()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string text = "";
                if ((text = sr.ReadLine()) != null)
                {
                    return text;
                }
                else
                {
                    return "";
                }
                
            }
        }
    }
}
