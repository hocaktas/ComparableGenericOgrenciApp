using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableGenericOgrenciApp
{
    class Ogrenci : IComparable
    {

        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Yas
        {
            get
            {
                var yas = DateTime.Now - this.DogumTarihi;
                return (int)yas.TotalDays / 365;
            }

        }
        public Ogrenci(int no, string ad,string soyad, DateTime dogumTarihi)
        {
            this.No = no;
            this.Ad = ad;
            this.Soyad = soyad;
            this.DogumTarihi = dogumTarihi;
        }
      
        public override string ToString()
        {
            return string.Format("Öğrenci No:{0}\n\tAdı:{1}\n\tSoyadı:{2}\n\tYaşı:{3}",this.No,this.Ad,this.Soyad,this.Yas);
        }

        public int CompareTo(object obj)
        {
            Ogrenci o = (Ogrenci)obj;
            return No.CompareTo(o.No);
          
        }
    }
}
