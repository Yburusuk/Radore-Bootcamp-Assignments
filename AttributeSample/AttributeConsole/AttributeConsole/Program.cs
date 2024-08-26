using ZorunlulukAttribute;

namespace AttributeConsole;

public class Program
{
    public static void Main()
    {
        Ogrenci ogrenci = new Ogrenci();
        
        ogrenci.ad = "Yavuz";
        ogrenci.soyad = "Buruşuk";
        ogrenci.bolum = "Bilgisayar Mühendisliği";

        if (!ZorunlulukKontrolu.Dogrula(ogrenci))
        {
            Console.WriteLine("Öğrenci bilgileri eksik.");
        }
        else
        {
            Console.WriteLine($"Öğrenci bilgileri alındı: {ogrenci.ad} {ogrenci.soyad}, {ogrenci.bolum}");
        }
    }
}

