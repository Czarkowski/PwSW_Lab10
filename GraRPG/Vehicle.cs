using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    public abstract class Vehicle
    {
        public readonly string name;

        public override string ToString()
        {
            return string.Format("Nazwa: {0}",name);
        }

        protected Vehicle(string name)
        {
            this.name = name;
        }
    }

    public class WarriorVehicle : Vehicle
    {
        public WarriorVehicle(string name) : base("Wojowniczy " + name)
        {
        }
    }
    public class MageVehicle : Vehicle
    {
        public MageVehicle(string name) : base("Magiczny "+name)
        {
        }
    }
    public class ArcherVehicle : Vehicle
    {
        public ArcherVehicle(string name) : base("Szybki "+name)
        {
        }
    }
}
