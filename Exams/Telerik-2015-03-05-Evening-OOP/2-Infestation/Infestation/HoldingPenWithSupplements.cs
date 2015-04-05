using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Infestation
{
    public class HoldingPenWithSupplements : HoldingPen
    {
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            var unitType = commandWords[1];
            var unitId = commandWords[2];

            Unit unitToBeAdded = null;

            switch (unitType)
            {
                case "Marine":
                    unitToBeAdded = new Marine(unitId);
                    break;
                case "Parasite":
                    unitToBeAdded = new Parasite(unitId);
                    break;
                case "Queen":
                    unitToBeAdded = new Queen(unitId);
                    break;
                case "Tank":
                    unitToBeAdded = new Tank(unitId);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }

            if (unitToBeAdded != null)
            {
                this.InsertUnit(unitToBeAdded);
            }
        }

        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            var supplementType = commandWords[1];

            ISupplement supplement = null;
            switch (supplementType)
            {
                case "AggressionCatalyst": supplement = new AggressionCatalyst();
                    break;
                case "PowerCatalyst": supplement = new PowerCatalyst();
                    break;
                case "HealthCatalyst": supplement = new HealthCatalyst();
                    break;
                case "Weapon": supplement = new Weapon();
                    break;
                default: break;
            }

            var unitId = commandWords[2];
            var unit = this.GetUnit(unitId);
            if (unit != null)
            {
                unit.AddSupplement(supplement);
            }
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    Unit targetUnit = this.GetUnit(interaction.TargetUnit);

                    targetUnit.AddSupplement(new InfestationSpores());
                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
        }
    }
}
