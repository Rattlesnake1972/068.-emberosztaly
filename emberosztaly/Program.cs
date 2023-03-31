using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emberosztaly
{
    class ember
    {
        public string nev;
        public int kor;
        public string nem;
        public double telefonszam;
        public string lakcim;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<ember> emberlista = new List<ember>();

            // ember létrehozása

            ember e = new ember();
            ember e1 = new ember();
            ember e2 = new ember();
            ember e3 = new ember();

            e.nev = "Pisti";
            e.kor = 26;
            e.nem = "férfi";
            e.telefonszam = 06305584057;
            e.lakcim = "Budapest";

            e1.nev = "Gyula";
            e1.kor = 50;
            e1.nem = "férfi";
            e1.telefonszam = 06305569047;
            e1.lakcim = "Miskolc";


            e2.nev = "Eszter";
            e2.kor = 28;
            e2.nem = "nő";
            e2.telefonszam = 06702865566;
            e2.lakcim = "Debrecen";


            e3.nev = "Julcsi";
            e3.kor = 19;
            e3.nem = "nő";
            e3.telefonszam = 06202863948;
            e3.lakcim = "Győr";

            emberlista.Add(e);
            emberlista.Add(e1);
            emberlista.Add(e2);
            emberlista.Add(e3);

            /*for (int i = 0; i < emberlista.Count; i++)
            {
                Console.WriteLine(emberlista[i].nev + " " + emberlista[i].kor);
            }*/

            foreach (var item in emberlista)
            {
                Console.WriteLine(item.nev + " " + item.kor + " éves.");
            }

            ember maxkor = emberlista[0]; 
            ember minkor = emberlista[0];

            foreach (var item in emberlista)
            {
                if (item.kor > maxkor.kor)
                {
                    maxkor = item;
                }
            }

            foreach (var item in emberlista)
            {
                if (item.kor < minkor.kor)
                {
                    minkor = item;
                }
            }
            Console.WriteLine(maxkor.nev + " a legidősebb, " +maxkor.kor+ " éves.");
            Console.WriteLine(minkor.nev + " a legfiatalabb, " + minkor.kor + " éves.");

            
            Console.ReadLine();

        }
    }
}

