using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reflection.DAL;

namespace Reflection.BLL
{
  public  class DBTool
    {
        private static DbContext _dbInstance;

        public static DbContext DBInstance
        {
            get {

                if (_dbInstance==null)
                {
                    _dbInstance = new NORTHWNDEntities();
                }

                return _dbInstance;
                }
            
        }

    }
}
