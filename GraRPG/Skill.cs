using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    public abstract class Skill
    {
        public readonly string Name;      

        public abstract void Use();

        protected Skill(string name)
        {
            Name = name;
        }
    }

    public class WarriorSkill : Skill
    {
        public WarriorSkill(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return string.Format("Umiejętność wojownika: {0}", Name);
        }

        public override void Use()
        {
            Console.WriteLine(ToString());
        }

    }

    public class MageSkill : Skill
    {
        public MageSkill(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return string.Format("Umiejętność maga: {0}", Name);
        }

        public override void Use()
        {
            Console.WriteLine(ToString());
        }
    }

    public class ArcherSkill : Skill
    {
        public ArcherSkill(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return string.Format("Umiejętność łucznika: {0}", Name);
        }

        public override void Use()
        {
            Console.WriteLine(ToString());
        }
    }
}
