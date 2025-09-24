using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Lion : Animal, ICanRun
    {
        public Lion(string name, int age, int startHp) : base(name, age, startHp)
        {
            Diet = Diet.Carnivore;
            DietMultiplier = 2.0;
        }

        public override string Speak()
        {
            return "Rawr";
        }
        //public override double DailyFoogKG()
        //{
        //    return 7.5;
        //}

        public int RunSpeedKmh()
        {
            return 24;
        }
    }
}
