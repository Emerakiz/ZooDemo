using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Elephant : Animal
    {
        public Elephant(string name, int age, int startHp) : base(name, age, startHp)
        {
        }

        public override string Speak()
        {
            return "chuu";
        }

        public override double DailyFoogKG()
        {
            return 10.0;
        }

        public string DoTrick()
        {
            return "lyfter en boll";
        }
    }
}
