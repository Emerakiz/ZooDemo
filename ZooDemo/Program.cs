namespace ZooDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            Animal Simba = new Lion("Simba", 10, 100);
            Animal Nala = new Lion("Nala", 8, 150);
            Animal Kovu = new Lion("Kovu", 3, 100);
            Animal Zazoo = new Parrot("Zazoo", 1, 40);
            Animal Dumba = new Elephant("Dumba", 4, 150);
            Animal Mei = new Elephant("Mei", 8, 200);

            zoo.Add(Simba);
            zoo.Add(Zazoo);
            zoo.Add(Dumba);
            zoo.Add(Mei);
            zoo.Add(Nala);
            zoo.Add(Kovu);

            

            Console.WriteLine($"Totalt amount of animals: {Animal.TotalCount}");

            zoo.ListAll();

            zoo.AllSpeak();

            zoo.ShowFeedingPlan();

            zoo.ShowTricks();
            zoo.TotaltAmountFood();

            zoo.ShowFlySpeed();

            zoo.ShowSpeed();

            zoo.ShowRunSpeedSorted();

            Console.WriteLine("");

            Console.WriteLine(Zazoo.Info());

            Zazoo.HP -= 10;
            Console.WriteLine(Zazoo.HP);

            Zazoo.Heal();
            Zazoo.Birthday();

            Console.WriteLine(Zazoo.ToString());

            Console.WriteLine("Search for an animal");
            //zoo.FindByName(Console.ReadLine());

            Console.WriteLine("== Carnivore ==");
            zoo.ListAllByDiets(Diet.Carnivore);
            Console.WriteLine("== Omnivore ==");
            zoo.ListAllByDiets(Diet.Omnivore);
            Console.WriteLine("== Herbivore ==");
            zoo.ListAllByDiets(Diet.Herbivore);
        }
    }
}
