using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    public abstract class Character
    {
        
        protected string className;
        protected List<IArtifact> artifacts;
        protected List<Skill> skills;
        protected Wepon wepon;
        protected Vehicle vehicle;
        public virtual void AddArtifacts(IArtifact artifact)
        {
            artifacts.Add(artifact);
        }

        protected void AddSkill(Skill skill)
        {
            skills.Add(skill);
        }
        public string Name { get; set; }
        private int hp;

        public int Hp { get => hp; set => hp = value; }

        private int mp;

        public int Mp { get => mp; set => mp = value; }

        private int strength;

        public int Strength { get => strength; set => strength = value; }

        private int magicPower;

        public int MagicPower { get => magicPower; set => magicPower = value; }

        private int defense;

        public int Defense { get => defense; set => defense = value; }

        private int magicDefense;

        public int MagicDefense { get => magicDefense; set => magicDefense = value; }
        public List<IArtifact> Artifacts { get => artifacts; }
        public List<Skill> Skills { get => skills; }
        public virtual Vehicle Vehicle { get => vehicle; set => vehicle = value; }

        protected Character(int hp, int mp, int strength, int magicPower, int defense, int magicDefense, string name)
        {
            
            
            artifacts = new List<IArtifact>();
            skills = new List<Skill>();
            this.mp = mp;
            this.hp = hp;
            this.strength = strength;
            this.defense = defense;
            this.magicDefense = magicDefense;
            this.magicPower = magicPower;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Klasa {className}, Imie {Name}, HP:{hp}, MP:{mp}, Str:{strength}, MagPow:{magicDefense}, Def:{defense}, MagDef:{magicDefense}\n" +
                $"Broń {wepon}, Pojazd {vehicle}\n" +
                $"Atrefakty {artifacts.Count}\n" +
                $"Umiejętności { String.Join(", ",skills) }";
        }
    }

    public class Warrior : Character
    {
        public WarriorWepon WarriorWepon
        {
            get => (WarriorWepon)wepon;
            set => wepon = value;
        }
        public override Vehicle Vehicle
        {
            set
            {
                if (value is WarriorVehicle)
                {
                    vehicle = value;
                }
                else
                {
                    throw new Exception("Wrong wehicle type!");
                }
            }
        }

        public Warrior(string name) : base(150, 10, 30, 5, 30, 20, name)
        {
            className = "Wojownik";
        }

        public void AddSkill(WarriorSkill skill)
        {
            base.AddSkill(skill);
        }

        public override void AddArtifacts(IArtifact artifact)
        {
            if (artifact is IWarriorArtifact)
            {
                base.AddArtifacts(artifact);
            }
            else
            {
                throw new Exception("Wrong artifact type!");
            }
            
        }
    }
    public class Mage : Character
    {
        public MageWepon MageWepon
        {
            get => (MageWepon)wepon;
            set => wepon = value;
        }
        public override Vehicle Vehicle
        {
            set
            {
                if (value is MageVehicle)
                {
                    vehicle = value;
                }
                else
                {
                    throw new Exception("Wrong wehicle type!");
                }
            }
        }
        public void AddSkill(MageSkill skill)
        {
            base.AddSkill(skill);
        }

        public override void AddArtifacts(IArtifact artifact)
        {
            if (artifact is IMageArtifact)
            {
                base.AddArtifacts(artifact);
            }
            else
            {
                throw new Exception("Wrong artifact type!");
            }

        }
        public Mage(string name) : base(75, 50, 5, 30, 10, 40, name)
        {
            className = "Mag";

        }
    }

    public class Archer : Character
    {
        public ArcherWepon ArcherWepon
        {
            get => (ArcherWepon)wepon;
            set => wepon = value;
        }
        public override Vehicle Vehicle
        {
            set
            {
                if (value is ArcherVehicle)
                {
                    vehicle = value;
                }
                else
                {
                    throw new Exception("Wrong wehicle type!");
                }
            }
        }
        public void AddSkill(ArcherSkill skill)
        {
            base.AddSkill(skill);
        }

        public override void AddArtifacts(IArtifact artifact)
        {
            if (artifact is IArcherArtifact)
            {
                base.AddArtifacts(artifact);
            }
            else
            {
                throw new Exception("Wrong artifact type!");
            }

        }
        public Archer(string name) : base(100, 20, 20, 15, 25, 25, name)
        {
            className = "Łucznik";

        }
    }

}
