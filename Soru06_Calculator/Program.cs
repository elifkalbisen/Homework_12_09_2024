namespace Soru06_Calculator;

public class HesapMakinesi
{
        public double Topla(double a, double b)
    {
        return a + b;
    }

    
    public double Cikar(double a, double b)
    {
        return a - b;
    }


    public double Carp(double a, double b)
    {
        return a * b;
    }

    public double Bol(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Bölme işlemi için bölen sıfır olamaz.");
        }
        return a / b;
    }
}

public class BilimselHesapMakinesi : HesapMakinesi
{
    
    public double Sin(double aciDerece)
    {
        double aciRadyan = aciDerece * (Math.PI / 180);
        return Math.Sin(aciRadyan);
    }

    
    public double Kos(double aciDerece)
    {
        double aciRadyan = aciDerece * (Math.PI / 180);
        return Math.Cos(aciRadyan);
    }

    
    public double Tan(double aciDerece)
    {
        double aciRadyan = aciDerece * (Math.PI / 180);
        return Math.Tan(aciRadyan);
    }
}


class Program
{
    static void Main(string[] args)
    {
        BilimselHesapMakinesi bilimselHesap = new BilimselHesapMakinesi();

        Console.WriteLine("Toplama: " + bilimselHesap.Topla(5, 3));           
        Console.WriteLine("Çıkarma: " + bilimselHesap.Cikar(5, 3));          
        Console.WriteLine("Çarpma: " + bilimselHesap.Carp(5, 3));            
        Console.WriteLine("Bölme: " + bilimselHesap.Bol(5, 3));              
        Console.WriteLine("Sinüs: " + bilimselHesap.Sin(30));               
        Console.WriteLine("Kosinüs: " + bilimselHesap.Kos(60));             
        Console.WriteLine("Tanjent: " + bilimselHesap.Tan(45));              
    }
}
