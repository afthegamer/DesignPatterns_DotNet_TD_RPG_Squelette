using RPGCombatSimulator.Characters;

namespace RPGCombatSimulator.States;

public class DeadState:CharacterState
{
    public DeadState(Character character) : base(character)
    {
    }

    public override void TakeDamage(int damage)
    {

    }

    public override double GetAttackModifier()
    {
        return 0;
    }

    public override bool CanAttack()
    {
        return false;
    }

    public override string GetStateDescription()
    {
        return "is dead.";
    }

    public override bool IsAlive() => false;
}