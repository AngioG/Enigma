using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Colore
    {
        public bool InUso { get; set; }
        public Color Color {get;set;}

        public Colore(Color c)
        {
            InUso = false;
            Color = c;
        }
    }
}
