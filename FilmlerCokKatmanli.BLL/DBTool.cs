using FilmlerCokKatmanli.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmlerCokKatmanli.BLL
{
   public class DBTool
    {
        public static FilmlerDBEntities _dbIntance;
        public static FilmlerDBEntities DbIntance
        {
            get
            {
                if (_dbIntance==null)
                {
                    _dbIntance = new FilmlerDBEntities();
                }
                return _dbIntance;
            }
        }
    }
}
