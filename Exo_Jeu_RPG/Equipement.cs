using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Jeu_RPG
{
    public interface IRecyleInterface
    {
        List<Materiau> Recycle();
    }

    public class Equipement : Item, IRecyleInterface
    {
        public string Rarete;
        public List<Materiau> Ressource = new List<Materiau>();

        public Equipement(string name, string type, int prix, string rarete, List<Materiau> ressource) : base(name, type, prix)
        {
            Rarete = rarete;
            Ressource = ressource;
        }

        public List<Materiau> Recycle()
        {
            return Ressource;
        }

    }
}
