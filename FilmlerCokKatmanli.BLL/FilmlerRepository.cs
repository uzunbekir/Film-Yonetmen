using FilmlerCokKatmanli.DAL;
using FilmlerCokKatmanli.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmlerCokKatmanli.BLL
{
   public class FilmlerRepository
    {
        FilmlerDBEntities db = new FilmlerDBEntities();

        public List<FilmForList> SelectBySupplierId(int Id)
        {
            return db.Filmlers.Where(i => i.YonetmenId == Id).Select(p => new FilmForList
            {
                FilmId = p.FilmId,
                FilmAdi = p.FilmAdi
            }).ToList();
        }

    }
}
