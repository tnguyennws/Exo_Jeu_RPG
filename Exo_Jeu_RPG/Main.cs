using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo_Jeu_RPG;

class Program
{
    static void Main(string[] args)
    {
        Sac sac = new Sac();
        Materiau Rubis = new Materiau("Rubis", "Minerai", 200);
        Materiau MineraiFer = new Materiau("Minerai de fer", "Minerai", 10);
        Materiau Sandwich = new Materiau("Sandwich Pourri", "Consommable", 1);
        Equipement Epee = new Equipement("Epée commune", "Arme", 300, "Commun", new List<Materiau>
        {
            MineraiFer,
            MineraiFer,
            MineraiFer
        });
        Equipement EpeeR = new Equipement("Epée épique", "Arme", 1500, "Rare", new List<Materiau>
        {
            MineraiFer,
            MineraiFer,
            MineraiFer,
            Rubis
        });

        sac.AddItem(MineraiFer);
        sac.AddItem(MineraiFer);
        sac.AddItem(MineraiFer);
        sac.AddItem(Rubis);
        sac.AddItem(Epee);
        sac.AddItem(EpeeR);
        sac.AddItem(Sandwich);

        sac.ShowContent();

        sac.Scrap(Epee.Recycle(), Epee);

        Console.WriteLine();

        sac.ShowContent();

        sac.Scrap(EpeeR.Recycle(), EpeeR);

        Console.WriteLine();

        sac.ShowContent();

    }
}
