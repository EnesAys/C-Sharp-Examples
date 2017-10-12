using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmlerKatmanli.DAL;
using FilmlerKatmanli.DTO;

namespace FilmlerKatmanli.BLL
{
  public class FilmRepository
    {
        FilmlerDBEntities db = new FilmlerDBEntities();
        public List<FilmForList> SelectFilm(int i)
        {
            return db.Filmlers.Where(x =>x.YonetmenID==i).Select(a=> new FilmForList
            {
                FilmAdi = a.FilmAd,
                FilmID = a.FilmID
            }).ToList(); 
        }
    }
}
