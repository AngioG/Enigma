using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Rotor : Reflector
    {
        public int Tipo { get; }
        public char Lettera { get; set; }

        public int Giri { get; set; }

        public int RingPos { get; set; }


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

            RingPos = 0;
            Lettera = 'A';
            Giri = 0;
            Tipo = tipo;
        }

        public override char Crypt(char l)
        {
            int aux = l - 65;
            aux = (aux + Giri - RingPos + 26) % 26;
            aux = alfabeto[aux] -65;

            char Crypted = (char)((aux - Giri + RingPos + 26) % 26+65);


            return (Crypted);
        }

        public char ReverseCrypt(char l)
        {
            int aux = (l - 65 + Giri - RingPos + 26) % 26;

            for (int i = 0; i < 26; i++)
                if (alfabeto[i] - 65 == aux)
                {
                    aux = i;
                    break;
                }


            aux = (aux - Giri + RingPos + 26) % 26;

            return (char)(aux + 65);
        }

        public bool RotateRotor(bool aumenta)
        {
            if(aumenta)
            {
                Giri += 1;

                if (Giri == 26)
                    Giri = 0;

                Lettera = (char)(65 + Giri);

                if (Giri == 0)
                    return true;

                return false;
            }
            else
            {
                Giri -= 1;

                if (Giri == -1)
                    Giri = 25;


                Lettera = (char)(65 + Giri);

                if (Giri == 22)
                    return true;
                return false;
            }

        }

        public void RotateRing(bool aumenta)
        {
            if (aumenta)
            {
                RingPos += 1;

                if (RingPos == 26)
                    RingPos = 0;
            }
            else
            {
                RingPos -= 1;

                if (RingPos == -1)
                    RingPos = 25;
            }

        }


        public override string ToString()
        {
            return Lettera.ToString();
        }
    }
}
