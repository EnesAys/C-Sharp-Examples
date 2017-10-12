using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmlerKatmanli.DAL;
using FilmlerKatmanli.DTO;

namespace FilmlerKatmanli.BLL
{
   public class Yonetmen_Repo
    {
        FilmlerDBEntities db = new FilmlerDBEntities();
        public List<YonetmenForList> SelectYonetmen()
        {
            return db.Yonetmenlers.Select(x => new YonetmenForList
            {
                YonetmenAdi = x.YonetmenAdi,
                YonetmenID = x.YonetmenID
            }).ToList();
        }
    }
}
