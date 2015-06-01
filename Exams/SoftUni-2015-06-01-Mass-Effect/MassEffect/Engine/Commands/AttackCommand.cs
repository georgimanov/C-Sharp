namespace MassEffect.Engine.Commands
{
    using System;

    using MassEffect.Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string command = commandArgs[0];
            var attackingShip = GetStarshipByName(commandArgs[1]);
            var deffendingShip = GetStarshipByName(commandArgs[2]);
            var projectile = attackingShip.ProduceAttack();

            deffendingShip.RespondToAttack(projectile);
            projectile.Hit(deffendingShip);
            deffendingShip.RespondToAttack(projectile);

            Console.WriteLine(Messages.ShipAttacked, attackingShip.Name, deffendingShip.Name);

            if (attackingShip.Health <= 0)
            {
                Console.WriteLine(Messages.ShipDestroyed, attackingShip.Name);
                return;
            }

            if (deffendingShip.Health <= 0)
            {
                Console.WriteLine(Messages.ShipDestroyed, deffendingShip.Name);
                return;
            }

            if (!deffendingShip.Location.Name.Equals(attackingShip.Location.Name))
            {
                Console.WriteLine(Messages.NoSuchShipInStarSystem);
                return;
            }
        }
    }
}
