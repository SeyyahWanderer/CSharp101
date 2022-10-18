using System;
namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Değişkenler, veri tutucularıdır. Verileri sakladığımız slottaki yapılardır. Her birinin bellekte bir karşılığı vardır yani bellekte bir yer belirlenmiş oluyor.
            Doğru verileri doğru veri tiplerinde tutmazsak da ileride hataya neden olabilir. 
            Değişken tanımlanırken dikkat edilmesi gerekenler:
            - Her zaman bir değeri olmak zorunda yani kullanmadan önce değer atanmış olması gerekiyor. Değer atanmadan kullanmaya çalışırsak compile time'da hata verir.
            *Compile Time; kod yazılırken IDE'nin kodu derlediği zamandır.
            - Case sensetive'lerdir yani büyük/küçük harfe duyarlıdırlar. Küçük harfle yazılmış bir değişkenin adının herhangi bir harfi büyük yazılırsa büyük harfle yazılan farklı bir değişken olur.
            - Değişken adları rakamla başlayamaz.
            - Yazılım diline özel isimler verilemez. örn : class gibi.
            - Aynı adı birden fazla aynı kod bloğu içinde yazılamaz.
            - İşlem operatörü içeremez. örn : degisken+veri gibi.
            - Sadece alt tire (_) kullanılabilir.
            */

            string degisken = " "; /*boş değildir. bir boşluk tanımlanmıştır.*/
            //Tam Sayılar
            byte b = 5; /*1 byte yer kaplar bellekte. 0-255 arasında değer alabilir.*/
            sbyte c=5; /*1 byte yer kaplar bellekte. (-128)-(127) arasında değer alabilir.*/
            short s = 5; /*2 byte yer kaplar bellekte. -32768-32768 arasında değer alabilir.*/
            ushort us = 5; /*2 byte yer kaplar bellekte. 0-65365 arasında değer alabilir.*/
            Int16 i16 =2; /*2 byte yer kaplar bellekte.*/
            int i=2; /*4 byte*/
            Int32 i32 =2; /*4 byte*/
            Int64 i64 = 2; /*8 byte*/
            uint ui =2; /*4 bbyte*/
            long l = 2; /*8 byte*/
            ulong ul = 2; /*8 byte*/
            //Reel Sayılar
            float f = 5; /*4 bbyte*/
            double d = 5; /*8 byte*/
            decimal de = 5; /*16 byte*/
            char ch = '2'; /*2 byte*/
            string st = "2"; /*sınırsız*/
            bool b1=true;
            bool b2 = false;
            DateTime dt = DateTime.Now; /*tarih*/
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 2;
            object o4 =4.15;

            //String İfadeler
            string str1 = string.Empty; /*veya " " veya null da diyebiliriz. Hepsi aynıdır.*/
            str1 = "Seyyah WANDERER";
            string ad = "Seyyah";
            string soyad = "WANDERER";
            string tamAd = ad+" "+soyad;

            //Integer tanımlama şekilleri
            int int1 = 5;
            int int2 = 3;
            int int3 = int1+int2;

            //Boolean
            bool b3 = 10>2;

            //Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // Çıktısı 2020

            int int21 = int20+Convert.ToInt32(str20);
            Console.WriteLine(int21); // Çıktısı 40

            int int22 = int20+int.Parse(str20); // Çıktısı 40

            //DateTime

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime1);

            string dateTime2 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(dateTime2);
        }
    }
}