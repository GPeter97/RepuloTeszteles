using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crepulok
{
    public class Jaratkezelo
    {
        List<Jarat> Reulogeptest = new List<Jarat>();

        public void UjJarat(string jaratszam, string repuloterHonnan, string repuloterHova, DateTime indulas)
        {
            Jarat jarat = new Jarat();
            jarat.jaratszam = jaratszam;
            jarat.repuloterHonnan = repuloterHonnan;
            jarat.repuloterHova = repuloterHova;
            jarat.indulas = indulas;
            jarat.keses = 0;
            Reulogeptest.Add(jarat);
        }

        public void Keses(string jaratszam, int keses)
        {
            for (int i = 0; i < Reulogeptest.Count; i++)
            {
                if (Reulogeptest[i].jaratszam==jaratszam)
                {
                    Reulogeptest[i].keses += keses;
                }
            }
        }

        public DateTime MikorUndul(string jarat)
        {
           DateTime Indul=  DateTime.Now;
            for (int i = 0; i < Reulogeptest.Count; i++)
            {
                if (Reulogeptest[i].jaratszam == jarat)
                {
                    Indul = Reulogeptest[i].indulas;
                }
            }
            return Indul;
        }
        public List<string> JartatokRepuloterrol(string repter)
        {
            List<string> repterek = new List<string>();

            return repterek;
        }
        public string getJaratSzam(string jaratSzam)
        {
            return Keres(jaratSzam).jaratszam;
        }

        public string Uticel(string jaratSzam)
        {
            return Keres(jaratSzam).repuloterHova;
        }

        public DateTime getIndulas(string jaratSzam)
        {
            return Keres(jaratSzam).indulas;
        }

        public int getKeses(string jaratSzam)
        {
            return Keres(jaratSzam).keses;
        }

        public int setKeses(string jaratSzam, int keses)
        {
            Keres(jaratSzam).keses = keses;

            return Keres(jaratSzam).keses;
        }

        Jarat Keres(string jaratSzam)
        {
            foreach (var j in Reulogeptest)
            {
                if (j.jaratszam.Equals(jaratSzam))
                {
                    return j;
                }
            }
            throw new Roszjaratszam(jaratSzam);
        }
    }
}
