using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODCMailTask.Helper;
using System.IO;

namespace ODCMailTask.Helper
{
   public class Audit
    {
        public enum AuiditFileName { Undefined, XMLRequest, XMLResponse };
        public static void WriteTextToFile(string text, AuiditFileName fileName)
        {
            string filePath = Directory.GetCurrentDirectory() + @"\" + fileName + ".txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            using (var writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine("-----------------------------");
                writer.WriteLine(text);
                writer.WriteLine("-----------------------------");
            }

        }
    }
}
