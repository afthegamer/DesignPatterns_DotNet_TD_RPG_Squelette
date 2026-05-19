using RPGCombatSimulator.Characters;

namespace RPGCombatSimulator.States;

public class HealtyState:CharacterState
{
    public HealtyState(Character character) : base(character)
    {
    }

    public override void TakeDamage(int damage)
    {
        _character.Health -= damage;
        if (_character.Health <= 50)
        {
            _character.ChangeState(new WoundedState(_character));
        }
    }

    public override double GetAttackModifier()
    {
        return 1.0;
    }

    public override bool CanAttack()
    {
        return true;
    }

    public override string GetStateDescription()
    {
        return "is in perfect health.";
    }
}