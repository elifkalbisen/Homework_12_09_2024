namespace Soru10_Game_Characters;

public class Character
{
    
    public string Isim { get; set; }
    
    
    public int Saglik { get; set; }

    
    public void BilgiGoster()
    {
        Console.WriteLine($"Karakter: {Isim}, Sağlık: {Saglik}");
    }
}


public class Warrior : Character
{
    
    public void KılıçSaldırısı()
    {
        Console.WriteLine($"{Isim} kılıçla saldırdı!");
    }
}


public class Mage : Character
{
    
    public void BüyüAtma()
    {
        Console.WriteLine($"{Isim} büyü yaptı!");
    }
}


public class Archer : Character
{
    
    public void OkAtma()
    {
        Console.WriteLine($"{Isim} ok attı!");
    }
}


class Program
{
    static void Main(string[] args)
    {
        
        Warrior savasci = new Warrior
        {
            Isim = "Kahraman",
            Saglik = 100
        };
        savasci.BilgiGoster();  
        savasci.KılıçSaldırısı(); 

        
        Mage buyucu = new Mage
        {
            Isim = "Bilge",
            Saglik = 80
        };
        buyucu.BilgiGoster();   
        buyucu.BüyüAtma();     

        
        Archer okcu = new Archer
        {
            Isim = "Usta Okçular",
            Saglik = 90
        };
        okcu.BilgiGoster();   
        okcu.OkAtma();       
    }
}