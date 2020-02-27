using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaSenac2020.Model
{
    class Clientes
    {
        private static int cpf;
        private static string nome;
        private static string fone;
        private static string endereco;

        public static int Cpf { get => cpf; set => cpf = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Fone { get => fone; set => fone = value; }
        public static string Endereco { get => endereco; set => endereco = value; }
    }
}
