using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaSenac2020.Model
{
    class Veiculos
    {
        private static int codigo;
        private static string marca;
        private static string modelo;
        private static string cor;
        private static string placa;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Marca { get => marca; set => marca = value; }
        public static string Modelo { get => modelo; set => modelo = value; }
        public static string Cor { get => cor; set => cor = value; }
        public static string Placa { get => placa; set => placa = value; }
    }
}
