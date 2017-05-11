using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mal_sat
{
    class Program
    {
        static void Main(string[] args)
        {
            var depo = new depo(60);
            var magaza1 = new filial(20,"flo");
            var magaza2 = new filial(20,"Pull Bear");
            var magaza3 = new filial(20,"LC Waikiki");
            Console.WriteLine("birinci magazada satilan mallarin sayi: ");
            magaza1.satilanMallarinSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("ikinci magazada satilan mallarin sayi: ");
            magaza2.satilanMallarinSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("ucuncu magazada satilan mallarin sayi: ");
            magaza3.satilanMallarinSayi = int.Parse(Console.ReadLine());
            depo.mallariPayla(filial.filiallar);
            depo.print(filial.filiallar);
           


        }
        public class depo
        {

            public double mallarinSayi;
            public double butunSatilmishMallar=0;
            public double k;

            public depo(double mallarinsayi)
            {
                mallarinSayi = mallarinsayi;
            }
            public void mallariPayla(List<filial> flo)
            {
                foreach (var item in flo)
                {
                    butunSatilmishMallar += item.satilanMallarinSayi / item.gelenMallarinSayi;
                }

                k = mallarinSayi / butunSatilmishMallar ;
                foreach (var items in flo)
                {
                    items.gelenMallarinSayi = Math.Round(items.satilanMallarinSayi / items.gelenMallarinSayi * k);
                }
            }
            public static void print(List<filial> romantic)
            {
                foreach (var item in romantic)
                {
                    Console.WriteLine($"\n {item.name} - a    {item.gelenMallarinSayi} mal gonderin...");
                }
                
            }
        }
        public class filial
        {
            public string name ;
            public double gelenMallarinSayi;
            public double satilanMallarinSayi;
            public static List<filial> filiallar = new List<filial>();
            public filial(double gelenmallarinsayi,string ad)
            {
                name = ad;
                gelenMallarinSayi = gelenmallarinsayi;
                filiallar.Add(this);
            }
        }
    }
}
