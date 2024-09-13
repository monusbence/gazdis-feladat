using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beolvasas_gyak
{
    internal class Emberek
    {
        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }
        public int Eletkor { get; set; }

        public int iD { get; set; }

        public Emberek(string vezetekNev, string keresztNev, int eletkor, int id)
        {
            VezetekNev = vezetekNev;
            KeresztNev = keresztNev;
            Eletkor = eletkor;
            iD = id;

        }
    }
}
