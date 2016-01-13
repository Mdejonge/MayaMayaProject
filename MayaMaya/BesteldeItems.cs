using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayaMaya
{
    public class BesteldeItems
    {
        public int id;
        public string naam;
        public double prijs;
        public int btw;
        public int status;
        public int aantal;
        public int bestel_id;
        public string betaalwijze;
        public double bestelTotaal;
        public double betaaldBedrag;

        public BesteldeItems(int id, string naam, double prijs, int btw, int status, int aantal, int bestel_id, string betaalwijze, double bestelTotaal, double betaaldBedrag)
        {
            this.id = id;
            this.naam = naam;
            this.prijs = prijs;
            this.btw = btw;
            this.status = status;
            this.aantal = aantal;
            this.bestel_id = bestel_id;
            this.betaalwijze = betaalwijze;
            this.bestelTotaal = bestelTotaal;
            this.betaaldBedrag = betaaldBedrag;
        }
    }
}
