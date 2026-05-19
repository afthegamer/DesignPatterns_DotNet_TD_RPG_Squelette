namespace RPGCombatSimulator.Strategies;

public class MagicAttackStrategy : IAttackStrategy
{
    public Double CalculateDamage(int baseDamage)
    {
        return baseDamage * 1.5;
    }

    public string GetAttackDescription()
    {
        return "casts a devastating spell!";
    }
}