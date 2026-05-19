namespace RPGCombatSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the RPG Combat Simulator!");

            var hero = new Characters.Character("Arthas", 100, 20, new Strategies.MeleeAttackStrategy());
            var villain = new Characters.Character("Diablo", 120, 25, new Strategies.MagicAttackStrategy());

            Console.WriteLine(hero.GetStatus());
            Console.WriteLine(villain.GetStatus());

            while (hero.IsAlive() && villain.IsAlive())
            {
                hero.Attack(villain);
                Console.WriteLine(villain.GetStatus());

                if (villain.IsAlive())
                {
                    villain.Attack(hero);
                    Console.WriteLine(hero.GetStatus());
                }
            }

            Console.WriteLine("Combat has ended!");
        }
    }
}
