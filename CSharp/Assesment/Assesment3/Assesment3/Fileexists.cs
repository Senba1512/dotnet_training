using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment3
{
     class Fileexists
    
        {
            public static void Write()
            {
                FileStream fs = new FileStream("MyFile.Txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("Enter the text to be add in the file:");
                string str = Console.ReadLine();
                sw.Write(str);
                sw.Close();
                fs.Close();
            }
            static void Main(string[] args)
            {
                Write();
            }
        }
    }
