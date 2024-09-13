using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Beolvasas_gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emberek> emberekList = new List<Emberek>();
            string fajlEmberek = "people.csv";
            List<kutya> kutyakList = new List<kutya>();
            string fajlKutyak = "dogs.csv";
            List<string> gazdis = new List<string>();

            using (StreamReader sr = new StreamReader(fajlEmberek))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    string[] elemek = sor.Split(';');
                    string vezetekNev = elemek[0];
                    string keresztNev = elemek[1];
                    int id = int.Parse(elemek[2]);
                    string[] eletkorAdatok = elemek[2].Split('-');
                    int eletkor = int.Parse(eletkorAdatok[1].Trim());

                    Emberek ember = new Emberek(vezetekNev, keresztNev, eletkor, id);
                    emberekList.Add(ember);
                }
            }

            var legfiatalabb = emberekList.OrderBy(x => x.Eletkor).First();
            var legidosebb = emberekList.OrderByDescending(x => x.Eletkor).First();
            var atlagEletkor = emberekList.Average(x => x.Eletkor);

            Console.WriteLine($"Legfiatalabb: {legfiatalabb.VezetekNev} {legfiatalabb.KeresztNev}, Életkor: {legfiatalabb.Eletkor}");
            Console.WriteLine($"Legidősebb: {legidosebb.VezetekNev} {legidosebb.KeresztNev}, Életkor: {legidosebb.Eletkor}");
            Console.WriteLine($"Átlag életkor: {atlagEletkor:F2}");

            using (StreamReader sr = new StreamReader(fajlKutyak))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    string[] kutyaElemek = sor.Split(';');
                    string nev = kutyaElemek[0];
                    string fajta = kutyaElemek[1];
                    int kor = int.Parse(kutyaElemek[2]);
                    int gazdaId = int.Parse(kutyaElemek[3]);

                    kutya kutyus = new kutya(nev, fajta, kor, gazdaId);
                    kutyakList.Add(kutyus);
                }
            }

            
        }
    }

}
