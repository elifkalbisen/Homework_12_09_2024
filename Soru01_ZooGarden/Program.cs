namespace Soru01_ZooGarden;

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion("Simba", 5);
        Elephant elephant = new Elephant("Dumbo", 10);
        Giraffe giraffe = new Giraffe("Melman", 7);

        lion.Info();
        lion.MakeSound();

        elephant.Info();
        elephant.MakeSound();

        giraffe.Info();
        giraffe.MakeSound();
    }
}
