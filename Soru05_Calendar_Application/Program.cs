namespace Soru05_Calendar_Application;

    class Etkinlik
    {
        public string Isim { get; set; }
        public DateTime Tarih { get; set; }
        public string Yer { get; set; }

        public Etkinlik(string isim, DateTime tarih, string yer)
        {
            Isim = isim;
            Tarih = tarih;
            Yer = yer;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Etkinlik: {Isim}, Tarih: {Tarih.ToShortDateString()}, Yer: {Yer}");
        }
    }

    class Toplanti : Etkinlik
    {
        public string Katilimcilar { get; set; }

        public Toplanti(string isim, DateTime tarih, string yer, string katilimcilar)
            : base(isim, tarih, yer)
        {
            Katilimcilar = katilimcilar;
        }

        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine($"Katilimcilar: {Katilimcilar}");
        }
    }

    class DogumGunu : Etkinlik
    {
        public string Sahibi { get; set; }

        public DogumGunu(string isim, DateTime tarih, string yer, string sahibi)
            : base(isim, tarih, yer)
        {
            Sahibi = sahibi;
        }

        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine($"Sahibi: {Sahibi}");
        }
    }

    class Gorev : Etkinlik
    {
        public bool TamamlandiMi { get; private set; }

        public Gorev(string isim, DateTime tarih, string yer)
            : base(isim, tarih, yer)
        {
            TamamlandiMi = false;
        }

        public void TamamlandiOlarakIsaretle()
        {
            if (TamamlandiMi)
            {
                Console.WriteLine($"{Isim} görevi zaten tamamlanmış.");
            }
            else
            {
                TamamlandiMi = true;
                Console.WriteLine($"{Isim} görevi tamamlandı olarak işaretlendi.");
            }
        }

        public new void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine($"Tamamlandı mı: {TamamlandiMi}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Toplanti toplanti = new Toplanti("Yıllık Planlama Toplantısı", DateTime.Now.AddDays(10), "Ofis", "Ali, Ayşe, Mehmet");
            DogumGunu dogumGunu = new DogumGunu("Ali'nin Doğum Günü", new DateTime(2024, 11, 15), "Ev", "Ali");
            Gorev gorev = new Gorev("Proje Sunumu", DateTime.Now.AddDays(5), "Online");

            toplanti.BilgileriGoster();
            Console.WriteLine();
            dogumGunu.BilgileriGoster();
            Console.WriteLine();
            gorev.BilgileriGoster();
            Console.WriteLine();

            gorev.TamamlandiOlarakIsaretle();
            gorev.BilgileriGoster();
        }
    }
