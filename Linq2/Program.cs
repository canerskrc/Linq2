//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linq2
//{
//    //public class Program
//    //{
//    //    //public static void Main(string[] args)
//    //    //{
//    //    //    string[] isimler = { "ras", "dslkj", "afkda", "çömdf", "lkmsdçöns", "roakqmnm" };
//    //    //    var Linq = from ad in isimler
//    //    //               where ad.Contains("r")
//    //    //               select ad;

//    //    //    foreach ( var sayac in Linq)
//    //    //    {
//    //    //        Console.WriteLine(sayac);
//    //    //    }
//    //    //}


//    //}


//    public class Calisanlar
//    {
//        public int cal_id
//        {
//            get; set;
//        }
//        public string cal_ad
//        {
//            get; set;
//        }
//        public string cal_cinsiyet
//        {
//            get; set;
//        }
//        public string cal_is_tarihi
//        {
//            get; set;
//        }

//        public int cal_maas
//        {
//            get; set;
//        }

//    }

//    public class ABC
//    {
//        static public void Main()
//        {
//            // Verileri ekleme

//            List<Calisanlar> liste = new List<Calisanlar>() {


//            new Calisanlar() { cal_id = 201, cal_ad = "Caner", cal_cinsiyet = "Erkek", cal_is_tarihi = "2015", cal_maas = 20000 },
//            new Calisanlar() { cal_id = 202, cal_ad = "Enes", cal_cinsiyet = "Erkek", cal_is_tarihi = "2020", cal_maas = 23000 },
//            new Calisanlar() { cal_id = 203, cal_ad = "Berfin", cal_cinsiyet = "Kadın", cal_is_tarihi = "2022", cal_maas = 27000 },
//            new Calisanlar() { cal_id = 204, cal_ad = "Mira", cal_cinsiyet = "Kadın", cal_is_tarihi = "2023", cal_maas = 29000 }, };


//            // where filtreleme

//            var xyz1 = from x1 in liste
//                       where x1.cal_id <= 203
//                       select x1.cal_ad;
//            foreach (var asd in xyz1)
//            {
//                Console.WriteLine(asd);
//            }
                // OfType Filtreleme
//            //var xyz2 = from x2 in liste.OfType<Calisanlar>()
//            //           select x2;
//            //foreach (var asd2 in xyz2)
//            //{
//            //    Console.WriteLine(asd2.cal_ad);
//            //}


//        }
//    }
//}
