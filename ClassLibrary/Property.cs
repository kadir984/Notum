using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clssOgrenci
    {
        public int OgrenciId { get; set; }
        public int AdSoyad { get; set; }
    }

    public class clssDers
    {
        public int DersId { get; set; }
        public int DersAdi { get; set; }
    }

    public class clssNotu
    {
        public int NotId { get; set; }
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        public int Notu { get; set; }
    }
}
