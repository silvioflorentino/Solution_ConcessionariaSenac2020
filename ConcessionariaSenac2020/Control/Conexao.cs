using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaSenac2020.Control
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\silvio.wflorentino\Desktop\Silvio_Florentino\C#_Noite\Solution_ConcessionariaSenac2020\ConcessionariaSenac2020\bdconcessionariasenac.mdf;Integrated Security=True ";
        }
    }
}
