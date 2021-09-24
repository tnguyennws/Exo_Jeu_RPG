using System;

namespace Exo_Jeu_RPG
{
    public abstract class Item
    {
        public string Name;
        public string Type;
        public int Prix;

        public Item(string Name, string Type, int Prix)
        {
            this.Name = Name;
            this.Type = Type;
            this.Prix = Prix;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
