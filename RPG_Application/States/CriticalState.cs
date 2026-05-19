using RPGCombatSimulator.Characters;

namespace RPGCombatSimulator.States;

public class CriticalState:CharacterState
{
    public CriticalState(Character character) : base(character)
    {
    }

    public override void TakeDamage(int damage)
    {
        _character.Health -= damage;
        if (_character.Health <= 0)
        {
            _character.Health = 0;
            _character.ChangeState(new DeadState(_character));
        }
    }

    public override double GetAttackModifier()
    {
        return 0.5;
    }

    public override bool CanAttack()
    {
        return true;
    }

    public override string GetStateDescription()
    {
        return "is in critical condition!";
    }
}