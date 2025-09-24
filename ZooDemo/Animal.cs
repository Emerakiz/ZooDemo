using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Diet { Carnivore, Omnivore, Herbivore }
namespace ZooDemo
{
    public abstract class Animal
    {
        public static int TotalCount = 0;
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Diet Diet { get; protected set; }

        protected double DietMultiplier;

        private int hp;
        private int maxHp;

        
        public int HP
        {
            get { return hp; }
            set
            {
                if(value < 0)
                {
                    hp = 0;
                }else if (value > maxHp)
                {
                    hp = maxHp;
                }else
                {
                    hp = value;
                }
            }
        }

        protected Animal(string name, int age, int startHp)
        {
            Name = name;
            Age = age;
            maxHp = startHp;
            HP = startHp;
            
            
            TotalCount++;

        }

        public abstract string Speak(); //Måste overridas
        public virtual double DailyFoogKG() //Kan overridas (frivilligt)
        {
            return 1.0 * DietMultiplier;
        }
        
        public string Info() // Standard, följer med automatisk, kan ej overridas
        {
            return $"{Name} | Age: {Age} | HP: {HP}";
        }

        public void GetSick(Animal a)
        {
            a.HP -= 10;
            Console.WriteLine($"{a.Name} got sick...");
        }
        public int Heal()
        {
            HP = maxHp;
            Console.WriteLine($"{Name} ate some medecine and got healthy again!");
            Info();
            return HP;
        }

        public override string ToString()
        {
            return $"{Name} | Age: {Age} | HP: {HP}";
        }

        public int Birthday()
        {
            return Age += 1;
        }
    }
}
