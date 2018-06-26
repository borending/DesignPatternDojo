using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Behavioral.Strategy
{
    public class Archer
    {
        IAttack Attack;

        public int PerformAttack(IAttack attack)
        {
            this.Attack = attack;
            return this.Attack.PerformAttack();
        }
    }
}
