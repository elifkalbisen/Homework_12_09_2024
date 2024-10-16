namespace Soru03_EMS;


    class Calisan
    {

        public string Isim { get; set; }
        public int KimlikNumarasi { get; set; }
        public decimal Maas { get; set; }


        public Calisan(string isim, int kimlikNumarasi, decimal maas)
        {
            Isim = isim;
            KimlikNumarasi = kimlikNumarasi;
            Maas = maas;
        }
    }


    class Yonetici : Calisan
    {

        public int TakimSayisi { get; set; }


        public Yonetici(string isim, int kimlikNumarasi, decimal maas, int takimSayisi)
            : base(isim, kimlikNumarasi, maas)
        {
            TakimSayisi = takimSayisi;
        }
    }


    class Gelistirici : Calisan
    {
  
        public string ProgramlamaDili { get; set; }

        public Gelistirici(string isim, int kimlikNumarasi, decimal maas, string programlamaDili)
            : base(isim, kimlikNumarasi, maas)
        {
            ProgramlamaDili = programlamaDili;
        }
    }

    // Stajyer sınıfı (Türetilmiş Sınıf)
    class Stajyer : Calisan
    {
        public int StajSuresi { get; set; }
        public string Bolum { get; set; }

        
        public Stajyer(string isim, int kimlikNumarasi, decimal maas, int stajSuresi, string bolum)
            : base(isim, kimlikNumarasi, maas)
        {
            StajSuresi = stajSuresi;
            Bolum = bolum;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Yonetici yonetici = new Yonetici("Ayşe", 1, 10000, 5);
            Console.WriteLine($"Yönetici: {yonetici.Isim}, Kimlik Numarası: {yonetici.KimlikNumarasi}, Maaş: {yonetici.Maas}, Takım Sayısı: {yonetici.TakimSayisi}");

            
            Gelistirici gelistirici = new Gelistirici("Mehmet", 2, 8000, "C#");
            Console.WriteLine($"Geliştirici: {gelistirici.Isim}, Kimlik Numarası: {gelistirici.KimlikNumarasi}, Maaş: {gelistirici.Maas}, Programlama Dili: {gelistirici.ProgramlamaDili}");

            
            Stajyer stajyer = new Stajyer("Ali", 3, 3000, 6, "Bilgisayar Mühendisliği");
            Console.WriteLine($"Stajyer: {stajyer.Isim}, Kimlik Numarası: {stajyer.KimlikNumarasi}, Maaş: {stajyer.Maas}, Staj Süresi: {stajyer.StajSuresi} ay, Bölüm: {stajyer.Bolum}");
        }
    }
