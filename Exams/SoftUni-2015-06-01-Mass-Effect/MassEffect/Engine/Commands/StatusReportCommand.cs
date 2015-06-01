namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;

    using MassEffect.Interfaces;

    public class StatusReportCommand : Command
    {
        public StatusReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string command = commandArgs[0];
            string starshipName = commandArgs[1];

            Console.WriteLine(GetStarshipByName(starshipName).ToString());
        }
    }
}
