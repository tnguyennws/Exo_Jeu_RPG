using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Jeu_RPG
{
    public class Sac
    {
        public List<Item> sac = new List<Item>();

        public void AddItem(Item item)
        {
            sac.Add(item);
        }

        public void Scrap(List<Materiau> scrap, Equipement dechet)
        {
            sac.AddRange(scrap);
            sac.Remove(dechet);
        }

        public void ShowContent()
        {
            IEnumerable<IGrouping<string, Item>> matos = sac.GroupBy(i => i.Name);
            foreach(IGrouping<string, Item> m in matos)
            {
                int count = m.Count();
                Console.WriteLine($"{m.First()} x {count} ({m.First().Prix*count})");
            }
        }
    }
}



    
