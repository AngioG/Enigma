using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Riflettore
    {
        public char[] alfabeto { get; set; }
        public int Tipo { get; set; }

        public Riflettore(int tipo)
        {

            string s = "";

            switch (tipo)
            {
                case 4:
                    {
                        s = "QYHOGNECVPUZTFDJAXWMKISRBL";
                        break;
                    }
                case 5:
                    {
                        s = "QWERTZUIOASDFGHJKPYXCVBNML";
                        break;
                    }
                default: throw new ArgumentException();
            }


            alfabeto = new char[26];

            for (int l = 0; l < s.Length; l++)
                alfabeto[l] = s[l];

            Tipo = tipo;
        }

        protected Riflettore()
        {

        }

        public virtual (bool, char) Cripta(char l)
        {
            int pos = l.GetHashCode() - 65;
            char criptato = alfabeto[pos];

            return (false, criptato);
        }

    }
}
