using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Zoo
    {
        private List<Animal> animals = new List<Animal>();

        public void Add(Animal animal)
        {
            animals.Add(animal);
        }

        public void ListAll()
        {
            if(animals.Count == 0)
            {
                Console.WriteLine("Inga djur i listan");
                return;
            }
            Console.WriteLine("=== Djur ===");
            for(int i = 0; i < animals.Count; i++)
            {
                Animal a = animals[i];
                Console.WriteLine($"{i + 1}. {a.Info()}");
            }
        }

        public void AllSpeak()
        {
            Console.WriteLine("Alla säger något");
            foreach(Animal a in animals)
            {
                Console.WriteLine($"{a.Name}: {a.Speak()}");
            }
        }

        public void ShowFeedingPlan()
        {
            Console.WriteLine("== Matplan (Kg/dag) ==");
            foreach(Animal a in animals)
            {
                Console.WriteLine($"{a.Name}: {a.DailyFoogKG()} kg");
            }
        }

        public void ShowTricks()
        {
            Console.WriteLine("== Do trick ==");
            foreach(Animal a in animals)
            {
                ITrick t = a as ITrick;

                if(t != null)
                {
                    Console.WriteLine($"{a.Name} {t.DoTrick()}");
                } else
                {
                    Console.WriteLine($"{a.Name} kan inga trick");
                }
            }
        }

        public void TotaltAmountFood()
        {
            double totalFood = 0;
            foreach (Animal a in animals)
            {
                totalFood += a.DailyFoogKG();
            }

            Console.WriteLine(totalFood);
        }

        public void ShowSpeed()
        {
            Console.WriteLine("== Speed ==");

            foreach(Animal a in animals)
            {
                ICanRun c = a as ICanRun;

                if (c != null)
                {
                    Console.WriteLine($"{a.Name} run at {c.RunSpeedKmh()}/Kmh");
                } else
                {
                    Console.WriteLine($"{a.Name} kan inte springa");
                }
            }
        }
    }
}
