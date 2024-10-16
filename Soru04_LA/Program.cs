namespace Soru04_LA;

class Kitap
{

    public string Baslik { get; set; }
    public string Yazar { get; set; }
    public int SayfaSayisi { get; set; }
    public string ISBN { get; set; }
    public bool OduncAlindiMi { get; private set; }

    
    public Kitap(string baslik, string yazar, int sayfaSayisi, string isbn)
    {
        Baslik = baslik;
        Yazar = yazar;
        SayfaSayisi = sayfaSayisi;
        ISBN = isbn;
        OduncAlindiMi = false;
    }

    public void OduncAl()
    {
        if (OduncAlindiMi)
        {
            Console.WriteLine($"{Baslik} kitabı zaten ödünç alınmış.");
        }
        else
        {
            OduncAlindiMi = true;
            Console.WriteLine($"{Baslik} kitabı ödünç alındı.");
        }
    }


    public void IadeEt()
    {
        if (!OduncAlindiMi)
        {
            Console.WriteLine($"{Baslik} kitabı ödünç alınmamış.");
        }
        else
        {
            OduncAlindiMi = false;
            Console.WriteLine($"{Baslik} kitabı iade edildi.");
        }
    }
}


class Kutuphane
{
    public Kitap[] Kitaplar { get; private set; }
    private int kitapSayisi;

    public Kutuphane(int kapasite)
    {
        Kitaplar = new Kitap[kapasite];
        kitapSayisi = 0;
    }


    public void KitapEkle(Kitap kitap)
    {
        if (kitapSayisi < Kitaplar.Length)
        {
            Kitaplar[kitapSayisi] = kitap;
            kitapSayisi++;
            Console.WriteLine($"{kitap.Baslik} kütüphaneye eklendi.");
        }
        else
        {
            Console.WriteLine("Kütüphane kapasitesi doldu!");
        }
    }


    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki Kitaplar:");
        for (int i = 0; i < kitapSayisi; i++)
        {
            Console.WriteLine($"- {Kitaplar[i].Baslik} (Yazar: {Kitaplar[i].Yazar})");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        
        Kutuphane kutuphane = new Kutuphane(5);

        
        Kitap kitap1 = new Kitap("1984", "George Orwell", 328, "1234567890123");
        Kitap kitap2 = new Kitap("Sefiller", "Victor Hugo", 1488, "9876543210123");

        
        kutuphane.KitapEkle(kitap1);
        kutuphane.KitapEkle(kitap2);

        
        kutuphane.KitaplariListele();

        
        kitap1.OduncAl();
        kitap1.IadeEt();
        kitap2.OduncAl();
        kitap2.IadeEt();
    }
}
