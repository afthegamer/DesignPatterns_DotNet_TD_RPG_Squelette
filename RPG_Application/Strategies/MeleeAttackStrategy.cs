namespace RPGCombatSimulator.Strategies;

public class MeleeAttackStrategy : IAttackStrategy
{
    public double CalculateDamage(int baseDamage)
    {
        return baseDamage * 1.2;
    }

    public string GetAttackDescription()
    {
        return "performs a powerful melee attack!";
    }
}