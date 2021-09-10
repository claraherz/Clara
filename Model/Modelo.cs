using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteo_Clara_RafaelGuilherme.Model
{
    public static class Modelo
    {
        public static string Preenche(string a, string b) // aqui é sorteia as letras dos quadrados onde tem 2 letras disponiveis
        {
            Random ran = new Random();
            if (ran.Next(1, 3) == 1)
            {
                return $"{a}";
            }
            else
            {
                return $"{b}";
            }
        }

        public static string Preenche2(string a, string b, string c) //aqui é sorteia as letras dos quadrados onde tem 3 letras disponiveis
        {
            Random ran = new Random();
            if (ran.Next(1, 4) == 1)
            {
                return $"{a}";
            }
            else if (ran.Next(1, 4) == 2)
            {
                return $"{b}";
            }
            else
            {
                return $"{c}";
            }
        }

        public static bool ConfereLetras(string a) //confere se tem letras repetidas
        {
            bool find_duplicate_letter = false;
            if (a != string.Empty)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    char b = Convert.ToChar(a.Substring(i,1));
                    if (i < a.Length - 1)
                    {
                        if (a.IndexOf(b, i + 1) > -1)
                        {
                            find_duplicate_letter = true;
                            break;
                        }
                    }


                }
            }

            return find_duplicate_letter;
        }

        

    }
}





