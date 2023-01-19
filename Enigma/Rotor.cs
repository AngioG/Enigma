using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            int partial = (l - 65 + Giri - RingPos + 26) % 26;

            partial = alfabeto[partial] - 65;

            partial = (partial - Giri + RingPos + 26) % 26;

            return (char)(partial+65);
        }

        public char ReverseCrypt(char l)
        {
            int partial = (l - 65 + Giri - RingPos + 26) % 26 + 65;

            partial =  Array.IndexOf(alfabeto, (char)partial);

            partial = (partial - Giri + RingPos + 26) % 26;

            return (char)(partial + 65);
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
