using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCMailTask.Helper
{
   public class ApiConstants
    {
        public const string INPUT_VALIDATION_ERROR = "Inputs validation error";
        public const string INPUT_VALIDATION = "Inputs are validated";

        //

        public const string apiURL = @"https://ppapi.smartmessage-engage.com/";
        public const string apiPATH = "SENDEML";
        public const string CONTENT_TYPE = "application/x-www-form-urlencoded";


        #region Sendml Request Constans

        public const string SENDEML = "SENDEML";
        public const string USR = "USR";
        public const string PWD = "PWD";
        public const string JID = "JID";
        public const string CG = "CG";
        public const string SBJ = "SBJ";
        public const string RCPT_LIST = "RCPT_LIST";
        public const string RCPT = "RCPT";
        public const string MSG = "MSG";
        public const string TA = "TA";

        #endregion

        #region Sendml Response Constans

        public const string EXP = "EXP";

        #endregion
    }
}
