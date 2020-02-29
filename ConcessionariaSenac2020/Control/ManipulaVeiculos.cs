using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ConcessionariaSenac2020.Model;
using System.Windows.Forms;

namespace ConcessionariaSenac2020.Control
{
    class ManipulaVeiculos
    {
       
        public void cadastrarVeiculos()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarVeiculos",cn);
            cmd.CommandType = CommandType.StoredProcedure;
           

            try
            {
                cmd.Parameters.AddWithValue("@marca",Veiculos.Marca);
                cmd.Parameters.AddWithValue("@modelo", Veiculos.Modelo);
                cmd.Parameters.AddWithValue("@cor",Veiculos.Cor);
                cmd.Parameters.AddWithValue("@placa",Veiculos.Placa);

                SqlParameter Agatha = cmd.Parameters.Add("@codigo", SqlDbType.Int);
                Agatha.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com Sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void visualizarCodigoVeiculos()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pVisuCodigoVeiculos",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Veiculos.Codigo);
                cn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Veiculos.Codigo =  Convert.ToInt32(dr["codigoVeiculos"]);
                    Veiculos.Marca = dr["marcaVeiculos"].ToString();
                    Veiculos.Modelo = dr["modeloVeiculos"].ToString(); ;
                    Veiculos.Cor = dr["corVeiculos"].ToString();
                    Veiculos.Placa = dr["placaVeiculos"].ToString();
                }
                else
                {
                    MessageBox.Show("Dados não Encontrados");
                }


            }
            catch (Exception)
            {

                throw;
            }

          
        }

     

    }

   

    
}
