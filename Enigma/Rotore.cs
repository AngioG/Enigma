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
                        s = "AMIFRVTPNEWKBLZYHJGDQOXUSC";
                        break;
                    }
                case 2:
                    {
                        s = "AEYUXHGQNTZPSFBOKMWRCJDIVL";
                        break;
                    }
                case 3:
                    {
                        s = "AKEQZPOSGXNRMWFLJVIUBHTCDY";
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
            char criptato = alfabeto[Giri];



            return (Gira(true), criptato);
        }

        public bool Gira(bool aumenta)
        {
            if(aumenta)
            {
                Giri += 1;

                if (Giri == 26)
                {
                    Giri = 0;
                    Lettera = alfabeto[Giri];
                    return true;
                }

                Lettera = alfabeto[Giri];
                return false;
            }
            else
            {
                Giri -= 1;

                if (Giri == -1)
                {
                    Giri = 25;
                    Lettera = alfabeto[Giri];
                    return true;
                }


                Lettera = alfabeto[Giri];
                return false;
            }

        }

        public override string ToString()
        {
            return Lettera.ToString();
        }
    }
}
