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
                Console.WriteLine("No animals in the list");
                return;
            }
            Console.WriteLine("=== Animals ===");
            for(int i = 0; i < animals.Count; i++)
            {
                Animal a = animals[i];
                Console.WriteLine($"{i + 1}. {a}");
            }
        }

        public void AllSpeak()
        {
            Console.WriteLine("== Animals make sounds ==");
            foreach(Animal a in animals)
            {
                Console.WriteLine($"{a.Name}: {a.Speak()}");
            }
        }

        public void ShowFeedingPlan()
        {
            Console.WriteLine("== Foodplan (Kg/day) ==");
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
                    Console.WriteLine($"{a.Name} can no tricks");
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
                    Console.WriteLine($"{a.Name} can't run ");
                }
            }
        }
        public void ShowRunSpeedSorted()
        {
            Console.WriteLine("== Run Speed Rank ==");

            List<Animal> sortedAnimals = animals.OrderByDescending(a => (a as ICanRun)?.RunSpeedKmh() ?? 0).ToList();

            foreach (Animal a in sortedAnimals)
            {
                ICanRun c = a as ICanRun;

                if (c != null)
                {
                    Console.WriteLine($"{a.Name}, {c.RunSpeedKmh()} Kmh");
                } else
                {
                    Console.WriteLine($"{a.Name}, 0 Kmh");
                }
               
            }
        }
        public void ShowFlySpeed()
        {
            Console.WriteLine("== Fly Speed ==");

            foreach (Animal a in animals)
            {
                IFly f = a as IFly;

                if (f != null)
                {
                    Console.WriteLine($"{a.Name} fly at {f.FlyingSpeedKmh()}/Kmh");
                }
                else
                {
                    Console.WriteLine($"{a.Name} can't fly ");
                }
            }
        }
        public Animal? FindByName(string name)
        {
            foreach (Animal a in animals)
            {
                if (a.Name == name)
                {
                    Console.WriteLine(a);
                    return a;
                }
            }
            Console.WriteLine("Could not find any animal by that name");
            return null;
        }

        public void ListAllByDiets(Diet diet)
        {
            foreach (Animal a in animals)
            {
                if(a.Diet == diet)
                {
                    Console.WriteLine($"{a} | {a.DailyFoogKG()}");
                }
            }
        }

    }
}
