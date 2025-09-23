using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Parrot : Animal, ITrick
    {
        public Parrot(string name, int age, int startHp) : base(name, age, startHp)
        {
        }

        public override string Speak()
        {
            return "pip";
        }

        public double DailyFoodKG()
        {
            return 0.5;
        }
        public string DoTrick()
        {
            return "Visslar en melodi";
        }
    }
}
