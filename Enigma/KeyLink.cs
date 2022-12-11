using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class KeyLink : IComparable
    {
        public char Letter1 { get; }
        public char Letter2 { get; }

        public KeyLink(char a, char b)
        {
            Letter1 = a;
            Letter2 = b;
        }

        public int CompareTo(object obj)
        {
            if(obj.GetType() != typeof(char)) return -1;

            char ToCompare = (char)obj;

            if(ToCompare == Letter1 || ToCompare == Letter2) return 0;

            return 1;
        }
    }
}
