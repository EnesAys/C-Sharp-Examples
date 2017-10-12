using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmler.DAL;

namespace Filmler.BLL
{
   public class FilmlerRepository
    {
        FilmlerDBEntities db = new FilmlerDBEntities();
        public void insert(Filmler.DAL.Filmler film)
        {
            db.Filmlers.Add(film);

        }
       
    }
}
