using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayaMaya
{
    class Tafels
    {
        public static int tafelnummer;


        public int tafelnummers { get; internal set; }
        public int tafelstatus { get; internal set; }

        public enum Status
        {
            Vrij,
            bezig,
            gereserveert,
            bezet
        };
    }
}
