using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCMailTask.Model
{
   public class XMLRequest
    {
        public XMLRequest(string content, string to_Mail)
        {
            MSG = content;
            TO = to_Mail;
        }
        public const string USR = "training_user";

        public const string PWD = "P@ssw0rd";

        public const string JID = "47de74b5-8c7e-4e33-a55a-a7ba00f4ecdc";

        public const string CG = "Standart";

        public const string SBJ = "SM Engage Campaign";

        public string MSG { get; set; }

        public string TO { get; set; }
    }
}
