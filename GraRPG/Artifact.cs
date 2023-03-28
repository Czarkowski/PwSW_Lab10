using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    public interface IArtifact
    {
        public void Use();
    }

    public interface IWarriorArtifact : IArtifact
    {
        public void WarriorArtifactUse();

    }

    public interface IMageArtifact : IArtifact
    {
        public void MageArtifactUse();
    }

    public interface IArcherArtifact : IArtifact
    {
        public void ArcherArtifactUse();
    }

    public class Artifact1 : IWarriorArtifact, IMageArtifact
    {

        public void Use()
        {
            Console.WriteLine("Use Artifact1");
        }

        public void MageArtifactUse()
        {
            Use();
        }

        public void WarriorArtifactUse()
        {
            Use();
        }
    }

    public class Artifact2 : IWarriorArtifact, IArcherArtifact
    {

        public void Use()
        {
            Console.WriteLine("Use Artifact2");
        }

        public void ArcherArtifactUse()
        {
            Use();
        }

        public void WarriorArtifactUse()
        {
            Use();
        }
    }
}
