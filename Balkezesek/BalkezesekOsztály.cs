using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    internal class BalkezesekOsztály
    {
        string nev;
        DateTime elsoPalyaraLepes;
        DateTime utolsoPalyaraLepes;
        int suly;
        int magassag;

        public BalkezesekOsztály(string nev, DateTime elsoPalyaraLepes, DateTime utolsoPalyaraLepes, int suly, int magassag)
        {
            this.nev = nev;
            this.elsoPalyaraLepes = elsoPalyaraLepes;
            this.utolsoPalyaraLepes = utolsoPalyaraLepes;
            this.suly = suly;
            this.magassag = magassag;
        }

        public string Nev { get => nev; }
        public DateTime ElsoPalyaraLepes { get => elsoPalyaraLepes; }
        public DateTime UtolsoPalyaraLepes { get => utolsoPalyaraLepes; }
        public int Suly { get => suly; }
        public int Magassag { get => magassag; }
    }
}
