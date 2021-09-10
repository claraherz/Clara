using Matteo_Clara_RafaelGuilherme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteo_Clara_RafaelGuilherme.Control
{
    public static class Controller
    {
        public static string Preenche(string a, string b) //aqui é a transição do model para o controller que finalmente chegará a view
        {
            return Modelo.Preenche(a, b);
        }

        public static string Preenche2(string a, string b, string c) //aqui é a transição do model para o controller que finalmente chegará a view
        {
            return Modelo.Preenche2(a, b, c);
        }

        public static bool Confere(string a) //aqui é a transição do model para o controller que finalmente chegará a view
        {
            return Modelo.ConfereLetras(a);
        }

        
    }
}
