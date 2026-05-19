namespace RPGCombatSimulator.Strategies;

public class RangedAttackStrategy : IAttackStrategy
{
    public double CalculateDamage(int baseDamage)
    {
        return baseDamage + Random.Shared.Next(5, 15);
    }

    public string GetAttackDescription()
    {
        return "performs a precise ranged attack!";
    }
}