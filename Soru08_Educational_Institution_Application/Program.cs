namespace Soru08_Educational_Institution_Application;

public class Person
{
    
    public string Isim { get; set; }
    
    
    public int Yas { get; set; }
}


public class Teacher : Person
{
    
    public string OgrettigiKonu { get; set; }

    
    public void DerseKatil()
    {
        Console.WriteLine($"{Isim} ({Yas} yaşında), {OgrettigiKonu} dersine katıldı.");
    }
}


public class Student : Person
{
    
    public string SinifSeviyesi { get; set; }

   
    public void DerseKatil()
    {
        Console.WriteLine($"{Isim} ({Yas} yaşında), {SinifSeviyesi} sınıfına katıldı.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        
        Teacher ogretmen = new Teacher
        {
            Isim = "Ali",
            Yas = 30,
            OgrettigiKonu = "Matematik"
        };

       
        Student ogrenci = new Student
        {
            Isim = "Ayşe",
            Yas = 15,
            SinifSeviyesi = "9. Sınıf"
        };

        
        ogretmen.DerseKatil();  
        ogrenci.DerseKatil(); 
    }
}