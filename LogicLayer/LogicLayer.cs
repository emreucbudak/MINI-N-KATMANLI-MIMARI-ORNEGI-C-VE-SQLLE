using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
namespace LogicLayer
{
    public class LogicLayer
    {
        public static List<EntityPersonel> LogicListele ()
        {
            return DALPERSONEL.listele();
        }
        public static int personelEkle(EntityPersonel p)
        {
            if (p.Ad != "" && p.Soyad != "" && p.Maas > 1000 && p.Gorev != ""  )
            {
                return DALPERSONEL.ekle(p);
            }
            else
            {
                return 0;
            }
        } 
        public static int personelGuncelle(EntityPersonel p)
        {
            if (p.Ad != "" && p.Soyad != "" && p.Maas > 1000 && p.Gorev != "")
            {
                return DALPERSONEL.guncelle(p);
            }
            else
            {
                return 0;
            }
        }
        public static int personelSil(int p)
        {
            if (p >= 1)
            {
                return DALPERSONEL.sil(p);
            }
            else
            {
                return 0;
            }
        }
    }
}
