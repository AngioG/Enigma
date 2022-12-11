using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Reflector
    {
        public char[] alfabeto { get; set; }
        public int Tipo { get; set; }

        public Reflector(int tipo)
        {

            string s = "";

            switch (tipo)
            {
                case 4:
                    {
                        s = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
                        break;
                    }
                case 5:
                    {
                        s = "FVPJIAOYEDRZXWGCTKUQSBNMHL";
                        break;
                    }
                default: throw new ArgumentException();
            }


            alfabeto = new char[26];

            for (int l = 0; l < s.Length; l++)
                alfabeto[l] = s[l];

            Tipo = tipo;
        }

        protected Reflector()
        {

        }

        public virtual char Crypt(char l)
        {
            int pos = l - 65;
            char Crypted = alfabeto[pos %26];

            return Crypted;
        }

    }
}
