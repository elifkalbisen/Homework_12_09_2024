namespace Soru02_TYS;

class Program
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void Info()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int numberOfDoors)
            : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    public class Bicycle : Vehicle
    {
        public bool HasBell { get; set; }

        public Bicycle(string make, string model, int year, bool hasBell)
            : base(make, model, year)
        {
            HasBell = hasBell;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"Has Bell: {HasBell}");
        }
    }

    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, int year, bool hasSidecar)
            : base(make, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"Has Sidecar: {HasSidecar}");
        }
    }
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Corolla", 2020, 4);
        Bicycle bicycle = new Bicycle("Giant", "Escape 3", 2021, true);
        Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Street 750", 2019, false);

        car.Info();
        bicycle.Info();
        motorcycle.Info();
    }
}
