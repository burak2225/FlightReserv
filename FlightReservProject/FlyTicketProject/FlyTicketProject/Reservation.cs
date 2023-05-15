using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTicketProject
{
    internal class Reservation
    {
        public Airplane Ucak;
        public Location Lokasyon;
        public Customer Musteri;
        public string Tarih;
        public string KoltukNo;


        public Reservation(Airplane ucak, Location lokasyon, Customer musteri, string tarih, string koltukno)
        {
            Ucak = ucak;
            Lokasyon = lokasyon;
            Musteri = musteri;
            Tarih = tarih;
            KoltukNo = koltukno;

        }
    }
}
