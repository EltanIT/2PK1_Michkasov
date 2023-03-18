using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_26
{
    class NewFile
    {
        private string path;

        string getNameFile;

        public NewFile(string nameFile)
        {
            if (nameFile == "")
            {
                
            }
            else
            {
                this.getNameFile = nameFile;
                path = @$"C:\Users\Гера\source\repos\2PK1_Michkasov\PZ_26\files\{getNameFile}.txt";
            }
        }


        public void createFile()
        {
            using(FileStream fs = File.Create(path))
            {
                byte[] text = new UTF8Encoding(true).GetBytes("");
                fs.Write(text, 0, text.Length);
            }
        }
    }
}
