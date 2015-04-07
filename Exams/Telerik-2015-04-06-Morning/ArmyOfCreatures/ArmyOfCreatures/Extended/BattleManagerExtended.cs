namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;

    public class BattleManagerExtended : BattleManager
    {
        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatures;

//        protected readonly Dictionary<int, ICollection<ICreaturesInBattle>> armies;

        public BattleManagerExtended(ICreaturesFactory creaturesFactory, ILogger logger) 
            : base(creaturesFactory, logger)
        {
            this.thirdArmyCreatures = new List<ICreaturesInBattle>();
//            this.armies = new Dictionary<int, ICollection<ICreaturesInBattle>>();
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            if (creaturesInBattle == null)
            {
                throw new ArgumentNullException("creaturesInBattle");
            }

            if (creatureIdentifier.ArmyNumber == 3)
            {
                this.thirdArmyCreatures.Add(creaturesInBattle);
                return;
            }

            base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            if (identifier.ArmyNumber != 1 && identifier.ArmyNumber != 2)
            {
                return this.thirdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }

            return base.GetByIdentifier(identifier);
        }
    }
}
