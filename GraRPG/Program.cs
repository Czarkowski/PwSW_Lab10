using System;

namespace GameRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Warrior("Artur");
            character1.Vehicle = new WarriorVehicle("Koń");
            ((Warrior)character1).WarriorWepon = new WarriorWepon(15);
            character1.AddArtifacts(new Artifact1());
            character1.AddArtifacts(new Artifact2());
            ((Warrior)character1).AddSkill(new WarriorSkill("Atak"));
            ((Warrior)character1).AddSkill(new WarriorSkill("Blok"));
            Console.WriteLine(character1);

            Console.WriteLine();

            Character character2 = new Mage("Morgana");
            character2.Vehicle = new MageVehicle("Miotła");
            ((Mage)character2).MageWepon = new MageWepon(15);
            character2.AddArtifacts(new Artifact1());
            //character2.AddArtifacts(new Artifact2());
            ((Mage)character2).AddSkill(new MageSkill("Błyskawica"));
            ((Mage)character2).AddSkill(new MageSkill("Teleportacja"));
            Console.WriteLine(character2);
        }
    }
}
