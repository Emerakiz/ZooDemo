using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Parrot : Animal, ITrick, IFly
    {
        public Parrot(string name, int age, int startHp) : base(name, age, startHp)
        {
            Diet = Diet.Omnivore;
        }

        public override string Speak()
        {
            return "kra";
        }

        
        public string DoTrick()
        {
            return "Whisle a melody";
        }

        public double FlyingSpeedKmh()
        {
            return 7;
        }
    }
}
