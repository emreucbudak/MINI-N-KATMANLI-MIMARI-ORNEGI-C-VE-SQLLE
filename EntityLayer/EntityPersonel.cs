using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int ID;
        private string ad;
        private string soyad;
        private string sehir;
        private int maas;
        private string gorev;

        public int ID1 { get => ID; set => ID = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public int Maas { get => maas; set => maas = value; }
        public string Gorev { get => gorev; set => gorev = value; }
    }
}
