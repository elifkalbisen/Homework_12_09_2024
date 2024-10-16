namespace Soru07_Store_Product_Management;

public class Product
{
    
    public string Isim { get; set; }
    
    
    public double Fiyat { get; set; }
    
    
    public int StokMiktari { get; set; }

    
    public bool StokuKontrolEt()
    {
        return StokMiktari > 0;
    }

    
    public void StokGuncelle(int miktar)
    {
        StokMiktari += miktar;
    }
}


public class FoodProduct : Product
{
    
    public DateTime SonKullanmaTarihi { get; set; }

    
    public bool SonKullanmaTarihiGecmisMi()
    {
        return DateTime.Now > SonKullanmaTarihi;
    }
}


public class ElectronicProduct : Product
{
    
    public int GarantiSuresiAy { get; set; }

    
    public bool GarantiGeçerliMi(DateTime alımTarihi)
    {
        DateTime garantiBitisTarihi = alımTarihi.AddMonths(GarantiSuresiAy);
        return DateTime.Now < garantiBitisTarihi;
    }
}


class Program
{
    static void Main(string[] args)
    {
        
        FoodProduct elma = new FoodProduct
        {
            Isim = "Elma",
            Fiyat = 5.0,
            StokMiktari = 100,
            SonKullanmaTarihi = new DateTime(2025, 12, 31)
        };

        Console.WriteLine($"Ürün: {elma.Isim}, Fiyat: {elma.Fiyat}, Stok: {elma.StokMiktari}");
        Console.WriteLine("Stok Durumu: " + (elma.StokuKontrolEt() ? "Mevcut" : "Tükenmiş"));
        Console.WriteLine("Son Kullanma Tarihi Geçmiş Mi: " + (elma.SonKullanmaTarihiGecmisMi() ? "Evet" : "Hayır"));

        
        ElectronicProduct telefon = new ElectronicProduct
        {
            Isim = "Akıllı Telefon",
            Fiyat = 3000.0,
            StokMiktari = 50,
            GarantiSuresiAy = 24
        };

        Console.WriteLine($"\nÜrün: {telefon.Isim}, Fiyat: {telefon.Fiyat}, Stok: {telefon.StokMiktari}");
        Console.WriteLine("Stok Durumu: " + (telefon.StokuKontrolEt() ? "Mevcut" : "Tükenmiş"));

        DateTime alımTarihi = new DateTime(2023, 10, 1);
        Console.WriteLine("Garanti Geçerli Mi: " + (telefon.GarantiGeçerliMi(alımTarihi) ? "Evet" : "Hayır"));
    }
}
