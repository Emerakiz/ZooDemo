using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Elephant : Animal, ITrick, ICanRun
    {

        public Elephant(string name, int age, int startHp) : base(name, age, startHp)
        {
            Diet = Diet.Herbivore;
            DietMultiplier = 5.0;
        }

        public override string Speak()
        {
            return "chuu";
        }



        public string DoTrick()
        {
            return $"{Name} lifts a ball";
        }

        public int RunSpeedKmh()
        {
            return 6;
        }
    }
}
