using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DAL;

namespace Northwind.BLL
{
   public class DBTool//BLL kısmında Shippersrepositoryden dan herseferde ınstance almak yerine bu clası açtık her seferinde innstance almayacağız.
    {
        private static NORTHWNDEntities _dbInstance;
        public static NORTHWNDEntities DbInstance
        {
            get
            {
                if (_dbInstance == null)
                {
                    _dbInstance = new NORTHWNDEntities();
                }
                return _dbInstance;
            }

        }
    }
}
