using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Cartas = new Dictionary<int, string>();
            Cartas.Add(1, "Espadas");
            Cartas.Add(3, "Espadas");
            Cartas.Add(4, "Espadas");
            Cartas.Add(7, "Diamantes");
            Cartas.Add(8, "Diamantes");
            Cartas.Add(9, "Diamantes");
            Cartas.Add(10, "Corazones");
            Cartas.Add(11, "Corazones");
            Cartas.Add(12, "Clubs");
            Cartas.Add(2, "Clubs");
        }
    }
}
