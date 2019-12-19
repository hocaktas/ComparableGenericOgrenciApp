using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableGenericOgrenciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci(27, "Ali", "Kara", new DateTime(2001, 10, 30)));
            ogrenciler.Add(new Ogrenci(100, "Kemalettin", "Aktaş", new DateTime(1987, 5, 18)));
            ogrenciler.Add(new Ogrenci(101, "Fatma", "Aktaş", new DateTime(1991, 2, 20)));
            ogrenciler.Add(new Ogrenci(199, "Muhammet", "Kalkan", new DateTime(1950, 5, 5)));

            foreach (Ogrenci item in ogrenciler)
            {
                Console.WriteLine(item);
            }
            ogrenciler.Sort();
            Console.WriteLine("------------------------------------------------------");
            foreach (Ogrenci item in ogrenciler)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
