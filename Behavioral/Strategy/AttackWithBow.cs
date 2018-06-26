using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Behavioral.Strategy
{
    public class AttackWithBow : IAttack
    {
        public int PerformAttack()
        {
            return 5;
        }
    }
}
