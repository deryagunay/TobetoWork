using System;

namespace pair1odev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 1
            //Console.WriteLine("Hello World!");
            //int order_id = 0;
            //Console.Write("Sipariş numarasını giriniz(1-4):");
            //order_id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" ");
            //Console.WriteLine("-----");
            //Console.WriteLine(" ");
            //switch (order_id)
            //{
            //    case 1:
            //        Console.WriteLine(order_id + " numaralı ürün");
            //        break;
            //    case 2:
            //        Console.WriteLine(order_id + " numaralı ürün");
            //        break;
            //    case 3:
            //        Console.WriteLine(order_id + " numaralı ürün");
            //        break;
            //    case 4:
            //        Console.WriteLine(order_id + " numaralı ürün");
            //        break;
            //    default:
            //        Console.WriteLine("Ürün bulunamadı.");
            //        break;

            //}
            //Soru 1 



            //Soru 2

            //Console.Write("Kaç adet ürün almak istersiniz:");
            //int piece = Convert.ToInt32(Console.ReadLine());
            //double totalPrice = 0, productPrice = 0;

            //for (int i = 0; i < piece; i++)
            //{
            //    Console.Write(i + 1 + ".ürünün fiyatını girin:");
            //    productPrice = Convert.ToDouble(Console.ReadLine());
            //    totalPrice += productPrice;
            //}
            //Console.WriteLine("Ödemeniz gereken toplam tutar:" + totalPrice.ToString());

            //Soru 2


            //Soru 3 do while döngüye ilk aşamada koşulsuz olarak girer devam etme koşulu döngünün sonunda kontrol edilir.

            //string condition = "";
            //do
            //{
            //    Console.Write("Kaç adet ürün almak istersiniz:");
            //    int piece = Convert.ToInt32(Console.ReadLine());
            //    double totalPrice = 0;
            //    double productPrice = 0;

            //    for (int i = 0; i < piece; i++)
            //    {
            //        Console.Write(i + 1 + ".ürünün fiyatını girin:");
            //        productPrice = Convert.ToDouble(Console.ReadLine());
            //        totalPrice += productPrice;
            //    }
            //    Console.WriteLine("Ödemeniz gereken toplam tutar:" + totalPrice.ToString());
            //    Console.WriteLine("");
            //    Console.Write("devam etmek istiyor musunuz?(E/H)");
            //    condition = Console.ReadLine().ToString().ToUpper();
            //    Console.WriteLine("");

            //} while (condition == "E");


            //while döngüsünde ilk önce koşul kontrol edilir.Şartlar sağlanıyorsa döngüye girer.
            //while (true)
            //{

            //}

            //Soru3 


            //Soru 4
            //string condition = "";
            //do
            //{

            //    int number = 0, total = 0;
            //    Console.Write("Mükemmel sayı kontrolü için sayı giriniz:");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 1; i < number; i++)
            //    {
            //        int control = number % i;
            //        if (control == 0)
            //        {
            //            total = total + i;
            //        }
            //    }
            //    if (total == number)
            //    {
            //        Console.WriteLine("Girdiğiniz sayı mükemmel sayıdır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girdiğiniz sayı mükemmel sayı değildir.");
            //    }


            //    Console.Write("devam etmek istiyor musunuz?(E/H)");
            //    condition = Console.ReadLine().ToString().ToUpper();
            //    Console.WriteLine("");
            //} while (condition == "E");
            //Soru 4



            //Soru 5


            //1. Length: Bir metnin karakter sayısını döndürür.

            //string lngth = "Merhaba dünya!";
            //int length = lngth.Length;
            //Console.WriteLine(length);
            ////2.ToUpper(): Bir metnin tüm karakterlerini büyük harfe çevirir.
            //string uppr = "Merhaba dünya!";
            //string upper = uppr.ToUpper();
            //Console.WriteLine(upper);
            //////3.ToLower(): Bir metnin tüm karakterlerini küçük harfe çevirir.
            //string lwr = "MERHABA DÜNYA!";
            //string lower = lwr.ToLower();
            //Console.WriteLine(lower);
            //////4. Substring(): Bir metnin belirli bir kısmını döndürür.
            //string sbt = "Merhaba dünya!";
            //string substring = sbt.Substring(7);
            //Console.WriteLine(substring);
            //////5.IndexOf(): Bir metnin içinde belirli bir karakterin veya dizenin ilk bulunduğu konumu döndürür.
            //string ınof = "Merhaba dünya!";
            //int index = ınof.IndexOf('a');
            //Console.WriteLine(index);
            //////6.Contains(): Bir metnin belirli bir karakteri veya diziyi içerip içermediğini kontrol eder.
            //string cnt = "Merhaba dünya!";
            //bool contains = cnt.Contains("dünya");
            //Console.WriteLine(contains);
            //////7.Replace(): Bir metnin içinde belirli bir karakteri veya diziyi başka bir karakter veya diziyle değiştirir.
            //string rpl = "Merhaba dünya!";
            //string replaced = rpl.Replace("dünya", "evren");
            //Console.WriteLine(replaced);
            //////8.Split(): Bir metni belirli bir karaktere veya diziye göre parçalara ayırır.
            //string spl = "Merhaba, dünya!";
            //string[] splitted = spl.Split(',');
            //foreach (string s in splitted)
            //{
            //    Console.WriteLine(s);
            //}
            //////9. Trim(): Bir metnin başındaki ve sonundaki boşlukları kaldırır.
            //string trm = "   Merhaba dünya!   ";
            //string trimmed = trm.Trim();
            //Console.WriteLine(trimmed);
            ////10.ToCharArray(): Bir metni karakter dizisine dönüştürür.
            //string str = "Merhaba dünya!";
            //char[] chars = str.ToCharArray();

            //foreach (char c in chars)
            //{
            //    Console.WriteLine(c);
            //}


            //Soru 5


            //Soru 6
            //double productPrice = 0;
            //double cargo = 50;
            //Console.Write("Ürünün fiyatını giriniz:");
            //productPrice = Convert.ToDouble(Console.ReadLine());
            //if (productPrice + cargo > 300)
            //{
            //    Console.WriteLine("Toplam tutar:" + productPrice);
            //}
            //else
            //{
            //    Console.WriteLine("Toplam tutar:" + productPrice + cargo);
            //}

            //Soru 6

            //Soru 7 7- iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.


            //Console.Write("1.ürünün fiyatını girin:");
            //double first = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2.ürünün fiyatını girin:");
            //double second = Convert.ToDouble(Console.ReadLine());
            //double total = first + second;
            //double totalPrice = 0;
            //string message = "";
            //if (total > 500)
            //{
            //    second = second - (second * 40) / 100;
            //    totalPrice = first + second;
            //    message = "2.üründe %40 indirim kazandınız.Ödenecek toplam tutar:" + totalPrice;
            //}
            //else
            //{
            //    totalPrice = first + second;
            //    message = "Ödenecek toplam tutar:" + totalPrice;
            //}
            //Console.WriteLine(message);

            //Soru 7


            //Soru 8  8 - 1 - 200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.

            int result = 0;
            for (int i = 0; i <= 200; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i.ToString());
                    result++;
                }

            }
            Console.WriteLine("Sonuç=" + result.ToString());
            //Soru 8
        }
    }
}
