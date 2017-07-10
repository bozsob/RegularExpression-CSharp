using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ConvertTextFileToDifferentEncodingType
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\boot.ini"))
                {
                    StreamWriter sw = new StreamWriter("boot-utf7.txt", false, Encoding.UTF7);
                    sw.WriteLine(sr.ReadToEnd());

                    sw.Close();
                    sr.Close();
                }
            }

            catch (Exception e)
            {
                throw new Exception("Error occured.", e);                
            }
        }
    }
}
