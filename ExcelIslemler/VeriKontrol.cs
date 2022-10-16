using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelIslemler
{
    internal class VeriKontrol
    {
        public string KurumAdi { get; set; }
        public double OdemeTutar { get; set; } = 0;

        public int Kactane { get; set; } = 1;

        public string Kisi { get; set; }

        public string VegiKimlikNo { get; set; }
        public string Iban { get; set; }
    }
}
