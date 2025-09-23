using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public abstract class Animal
    {
        public static int TotalCount = 0;
        private int hp;
        private int maxHp;
        public string Name { get; private set; }
        public int Age { get; private set; }

        public int HP
        {
            get { return hp; }
            set
            {
                if(value < 0)
                {
                    hp = 0;
                } else
                {
                    hp = value;
                }
            }
        }

        protected Animal(string name, int age, int startHp)
        {
            Name = name;
            Age = age;
            HP = startHp;
            TotalCount++;

        }

        public abstract string Speak(); //Måste overridas
        public virtual double DailyFoogKG() //Kan overridas (frivilligt)
        {
            return 1.0;
        }
        public string Info() // Standard, följer med automatisk, kan ej overridas
        {
            return $"{Name} | Age: {Age} | HP: {HP}";
        }

        public override string ToString()
        {
            return $"{Info()} blah blah";
        }
    }
}
