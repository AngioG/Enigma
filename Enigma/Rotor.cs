using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Rotor : Reflector
    {
        public char Lettera { get; set; }

        public int Giri { get; set; }


        public Rotor(int tipo) : base()
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

        public override char Crypt(char l)
        {
            int pos = l - 65;
            char Crypted = alfabeto[(pos + Giri) % 26];


            return (Crypted);
        }

        public void Gira(bool aumenta)
        {
            if(aumenta)
            {
                Giri += 1;

                if (Giri == 26)
                    Giri = 0;

                Lettera = (char)(65 + Giri);
            }
            else
            {
                Giri -= 1;

                if (Giri == -1)
                    Giri = 25;


                Lettera = (char)(65 + Giri);
            }

        }

        public override string ToString()
        {
            return Lettera.ToString();
        }
    }
}
