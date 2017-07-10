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
            StreamReader sr;
            StreamWriter sw;
            try
            {
                {
                    sr = new StreamReader(@"C:\Test\test.txt");
                    sw = new StreamWriter("test-utf7.txt", false, Encoding.UTF7);
                    sw.WriteLine(sr.ReadToEnd());
                    Debug.WriteLine("done");
                }
            }

            catch (Exception e)
            {
                throw new Exception("Error occured.", e);                
            }
            sw.Close();
            sr.Close();
        }
    }
}
