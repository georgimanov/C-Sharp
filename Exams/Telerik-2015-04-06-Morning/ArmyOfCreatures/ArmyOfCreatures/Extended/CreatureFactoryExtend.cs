namespace ArmyOfCreatures.Logic
{
    using ArmyOfCreatures.Extended;
    using ArmyOfCreatures.Extended.Creatures;
    using ArmyOfCreatures.Logic.Creatures;

    public class CreatureFactoryExtend : CreaturesFactory
    {
        public override Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "Goblin":
                    return new Goblin();
                case "Griffin":
                    return new Griffin();
                case "WolfRaider":
                    return new WolfRaider();
                default:
                    return base.CreateCreature(name);
            }
        }
    }
}
