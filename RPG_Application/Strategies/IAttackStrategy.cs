using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatSimulator.Strategies
{
    public interface IAttackStrategy
    {
        double CalculateDamage(int baseDamage);
        string GetAttackDescription();
    }
}
