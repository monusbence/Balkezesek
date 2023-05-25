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
        string elsoPalyaraLepes;
        string utolsoPalyaraLepes;
        int suly;
        int magassag;

        public BalkezesekOsztály(string nev, string elsoPalyaraLepes, string utolsoPalyaraLepes, int suly, int magassag)
        {
            this.nev = nev;
            this.elsoPalyaraLepes = elsoPalyaraLepes;
            this.utolsoPalyaraLepes = utolsoPalyaraLepes;
            this.suly = suly;
            this.magassag = magassag;
        }

        public string Nev { get => nev; }
        public string ElsoPalyaraLepes { get => elsoPalyaraLepes; }
        public string UtolsoPalyaraLepes { get => utolsoPalyaraLepes; }
        public int Suly { get => suly; }
        public int Magassag { get => magassag; }
    }
}
