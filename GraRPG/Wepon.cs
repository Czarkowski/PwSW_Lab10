using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    public abstract class Wepon
    {
        private int weponPower;

        public int WeponPower { get => weponPower; set => weponPower = value; }

        protected Wepon(int weponPower)
        {
            this.weponPower = weponPower;
        }

        public override string ToString()
        {
            return String.Format("Siła: {0}",weponPower);
        }
    }

    public class WarriorWepon : Wepon
    {
        public WarriorWepon(int weponPower) : base(weponPower)
        {
        }
    }

    public class MageWepon : Wepon
    {
        public MageWepon(int weponPower) : base(weponPower)
        {
        }
    }

    public class ArcherWepon : Wepon
    {
        public ArcherWepon(int weponPower) : base(weponPower)
        {
        }
    }
}
