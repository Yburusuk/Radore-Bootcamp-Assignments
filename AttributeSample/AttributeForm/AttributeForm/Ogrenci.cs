using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorunlulukAttribute;

namespace AttributeForm
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string ad;

        [ZorunluAlan]
        public string soyad;

        [ZorunluAlan]
        public string bolum;
    }
}
