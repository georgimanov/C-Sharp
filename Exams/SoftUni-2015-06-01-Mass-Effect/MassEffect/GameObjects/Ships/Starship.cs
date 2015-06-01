namespace MassEffect.GameObjects.Ships
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MassEffect.GameObjects.Enhancements;
    using MassEffect.GameObjects.Locations;
    using MassEffect.Interfaces;

    public abstract class Starship : IStarship
    {
        protected IList<Enhancement> enhancementsList;

        private int health;
        private int shields;
        private int damage;
        private double fuel;

        protected Starship(string name, StarSystem location, int health, int shileds, int damage, double fuel)
        {
            this.Name = name;
            this.Location = location;
            this.health = health;
            this.shields = shileds;
            this.damage = damage;
            this.fuel = fuel;
            this.enhancementsList = new List<Enhancement>();

        }

        public virtual IEnumerable<Enhancement> Enhancements
        {
            get
            {
                return this.enhancementsList;
            }
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            this.enhancementsList.Add(enhancement);
            ApplyEnhancements(enhancement);
        }

        public string Name { get; set; }

        public int Health
        {
            get
            {
                if (this.health <= 0)
                {
                    this.health = 0;
                }
                return this.health;
            }
            set { this.health = value; }
        }

        public int Shields
        {
            get
            {
                if (this.shields < 0)
                {
                    this.shields = 0;
                }

                return this.shields;
            }
            set { this.shields = value; }
        }

        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }

        public double Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }

        public StarSystem Location { get; set; }

        public StarshipType Type { get; set; }

        public virtual IProjectile ProduceAttack()
        {
            throw new NotImplementedException();
        }

        public virtual void RespondToAttack(IProjectile attack)
        {
        }

        public void ApplyEnhancements(Enhancement enhancement)
        {
            if (enhancement.DamageBonus > 0)
            {
                this.Damage += enhancement.DamageBonus;
            }

            if (enhancement.FuelBonus > 0)
            {
                this.Fuel += enhancement.FuelBonus;
            }

            if (enhancement.ShieldBonus > 0)
            {
                this.Shields += enhancement.ShieldBonus;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("--{0} - {1}", this.Name, this.Type));

            if (this.Health > 0)
            {
                sb.AppendLine(String.Format("-Location: {0}", this.Location.Name));
                sb.AppendLine(String.Format("-Health: {0}", this.Health));
                sb.AppendLine(String.Format("-Shields: {0}", this.Shields));
                sb.AppendLine(String.Format("-Damage: {0}", this.Damage));
                sb.AppendLine(String.Format("-Fuel: {0:f1}", this.Fuel));
                sb.AppendLine(String.Format("-Enhancements: {0}",
                    this.Enhancements.Any() ? String.Join(", ", this.Enhancements) : "N/A"));
            }
            else
            {
                sb.AppendLine("(Destroyed)");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
