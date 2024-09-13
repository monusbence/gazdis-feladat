using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beolvasas_gyak
{
    internal class kutya
    {
        string nev;
        string fajta;
        int kor;
        int gazdaId;

        public kutya(string nev, string fajta, int kor, int gazdaId)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.kor = kor;
            this.gazdaId = gazdaId;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Fajta { get => fajta; set => fajta = value; }
        public int Kor { get => kor; set => kor = value; }
        public int GazdaId { get => gazdaId; set => gazdaId = value; }
    }
}
