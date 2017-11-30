using FilmlerCokKatmanli.DAL;
using FilmlerCokKatmanli.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmlerCokKatmanli.BLL
{
    public class YonetmenlerRepository
    {
        FilmlerDBEntities db = DBTool.DbIntance;
        public List<YonetmenForList> SelectAll()
        {
            return db.Yonetmenlers.Select(i => new YonetmenForList
            { 
               YonetmenID=i.YonetmenId,
               Yonetmenadisoyadi=i.YonetmenAdi+" "+i.YonetmenSoyadi
            }).ToList();
        }
        }
}
