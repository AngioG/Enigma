using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Rotore : Riflettore
    {
        public char Lettera { get; set; }

        public int Giri { get; set; }


        public Rotore(int tipo) : base()
        {

            string s = "";

            switch (tipo)
            {
                case 1:
                    {
                        s = "JGDQOXUSCAMIFRVTPNEWKBLZYH";
                        break;
                    }
                case 2:
                    {
                        s = "NTZPSFBOKMWRCJDIVLAEYUXHGQ";
                        break;
                    }
                case 3:
                    {
                        s = "JVIUBHTCDYAKEQZPOSGXNRMWFL";
                        break;
                    }
                default: throw new ArgumentException();
            }


            alfabeto = new char[26];

            for (int l = 0; l < s.Length; l++)
                alfabeto[l] = s[l];

            Lettera = 'A';
            Giri = 0;
            Tipo = tipo;
        }

        public override (bool, char) Cripta(char l)
        {
            int pos = l.GetHashCode() - 65;
            char criptato = alfabeto[(pos + Giri) % 26];



            return (Gira(true), criptato);
        }

        public bool Gira(bool aumenta)
        {
            if(aumenta)
            {
                Lettera = (char)((Lettera.GetHashCode() + 1) % 26);
                Giri += 1;

                if (Giri == 26)
                {
                    Giri = 0;
                    return true;
                }

                return false;
            }
            else
            {
                int ascii = (char)(Lettera.GetHashCode() - 1);
                if (ascii == -1) ascii = 25;

                Lettera = (char)(ascii);
                Giri -= 1;

                if (Giri == -1)
                    Giri = 25;

                return false;
            }

        }

        public override string ToString()
        {
            return Lettera.ToString();
        }
    }
}
