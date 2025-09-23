namespace ZooDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            Animal Simba = new Lion("Simba", 10, 100);
            Animal Zazoo = new Parrot("Zazoo", 1, 40);
            Animal Dumba = new Elephant("Dumba", 4, 150);

            zoo.Add(Simba);
            zoo.Add(Zazoo);
            zoo.Add(Dumba);

            Console.WriteLine($"Totalt antal djur: {Animal.TotalCount}");

            zoo.ListAll();

            zoo.AllSpeak();

            zoo.ShowFeedingPlan();

            zoo.ShowTricks();

            Zazoo.HP = -10;
            Console.WriteLine(Zazoo.HP);

            zoo.TotaltAmountFood();

            zoo.ShowSpeed();

            Console.WriteLine(Zazoo.ToString());
        }
    }
}
