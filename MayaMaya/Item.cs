using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayaMaya
{
    public class Item
    {
        public int id;
        public int categorie_id;
        public int kaart_id;
        public string naam;
        private int voorraad;
        private double prijs;
        public int btw;

        public double Prijs
        {
            get
            {
                return prijs;
            }

            set
            {
                prijs = value;
            }
        }

        public int Voorraad
        {
            get
            {
                return voorraad;
            }

            set
            {
                voorraad = value;
            }
        }

        public Item(int id, int categorie_id, int kaart_id, string naam, int voorraad, double prijs, int btw)
        {
            this.id = id;
            this.categorie_id = categorie_id;
            this.kaart_id = kaart_id;
            this.naam = naam;
            this.Voorraad = voorraad;
            this.Prijs = prijs;
            this.btw = btw;
        }
    }

}
