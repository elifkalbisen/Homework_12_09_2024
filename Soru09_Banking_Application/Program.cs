namespace Soru09_Banking_Application;

public class Account
{
    
    public string HesapNumarasi { get; set; }
    
    
    public double Bakiye { get; protected set; } 


    public void ParaYatir(double miktar)
    {
        if (miktar > 0)
        {
            Bakiye += miktar;
            Console.WriteLine($"{miktar} TL yatırıldı. Yeni bakiye: {Bakiye} TL.");
        }
        else
        {
            Console.WriteLine("Yatırılacak miktar sıfırdan büyük olmalıdır.");
        }
    }

    
    public void ParaCek(double miktar)
    {
        if (miktar > 0 && miktar <= Bakiye)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi. Kalan bakiye: {Bakiye} TL.");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye veya geçersiz miktar.");
        }
    }
}


public class SavingsAccount : Account
{
    
    public double FaizOrani { get; set; }

    
    public void FaizEkle()
    {
        double faiz = Bakiye * FaizOrani / 100;
        Bakiye += faiz;
        Console.WriteLine($"Faiz eklendi: {faiz} TL. Yeni bakiye: {Bakiye} TL.");
    }
}


public class CheckingAccount : Account
{
    
    public void CekYaz(double miktar)
    {
        if (miktar > 0 && miktar <= Bakiye)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL'lik çek yazıldı. Kalan bakiye: {Bakiye} TL.");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye veya geçersiz miktar.");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        
        SavingsAccount tasarrufHesabi = new SavingsAccount
        {
            HesapNumarasi = "123456",
            FaizOrani = 5.0
        };
        
        tasarrufHesabi.ParaYatir(1000); 
        tasarrufHesabi.FaizEkle();      
        tasarrufHesabi.ParaCek(200);      

       
        CheckingAccount vadesizHesap = new CheckingAccount
        {
            HesapNumarasi = "654321"
        };
        
        vadesizHesap.ParaYatir(500);      
        vadesizHesap.CekYaz(100);          
        vadesizHesap.ParaCek(200);         
    }
}
