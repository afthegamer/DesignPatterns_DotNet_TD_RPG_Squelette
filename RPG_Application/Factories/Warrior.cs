using RPGCombatSimulator.Characters;
using RPGCombatSimulator.Strategies;

namespace RPGCombatSimulator.Factories;

public class Warrior: CharacterFactory
{
    public override Character CreateCharacter(string name, int maxHealth, int baseDamage, string type)
    {
        return new Character(name, maxHealth, baseDamage, new MeleeAttackStrategy());
    }
}