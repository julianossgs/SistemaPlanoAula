using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PlanodeAulas
{
    public class PlanoController
    {
        internal List<PlanoEnt> ListarPlanos()
        {
            using (SqlConnection Con = new SqlConnection())
            {
                Con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                Cmd.CommandText = "spListarPlanos";
                Cmd.Connection = Con;
                SqlDataReader dataReader;
                List<PlanoEnt> lista = new List<PlanoEnt>();
                dataReader = Cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        PlanoEnt dados = new PlanoEnt();
                        dados.IdPlano = Convert.ToInt32(dataReader["IdPlano"]);
                        dados.Data = Convert.ToDateTime(dataReader["Data"]);
                        dados.Hora = Convert.ToString(dataReader["Hora"]);
                        dados.Eixo = Convert.ToString(dataReader["Eixo"]);
                        dados.Objetivo = Convert.ToString(dataReader["Objetivo"]);
                        dados.Conteudo = Convert.ToString(dataReader["Conteudo"]);
                        dados.Metodologia = Convert.ToString(dataReader["Metodologia"]);
                        dados.Avaliacao = Convert.ToString(dataReader["Avaliacao"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }

        internal List<PlanoEnt> BuscarDatas(PlanoEnt obj)
        {
            using (SqlConnection Con = new SqlConnection())
            {
                Con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                Cmd.CommandText = "spBuscarData";
                Cmd.Parameters.Add("DataInicio", SqlDbType.DateTime).Value = obj.DataInicial;
                Cmd.Parameters.Add("DataFim", SqlDbType.DateTime).Value = obj.DataFinal;
                Cmd.Connection = Con;
                SqlDataReader dataReader;
                List<PlanoEnt> lista = new List<PlanoEnt>();
                dataReader = Cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        PlanoEnt dados = new PlanoEnt();
                        dados.IdPlano = Convert.ToInt32(dataReader["IdPlano"]);
                        dados.Data = Convert.ToDateTime(dataReader["Data"]);
                        dados.Hora = Convert.ToString(dataReader["Hora"]);
                        dados.Eixo = Convert.ToString(dataReader["Eixo"]);
                        dados.Objetivo = Convert.ToString(dataReader["Objetivo"]);
                        dados.Conteudo = Convert.ToString(dataReader["Conteudo"]);
                        dados.Metodologia = Convert.ToString(dataReader["Metodologia"]);
                        dados.Avaliacao = Convert.ToString(dataReader["Avaliacao"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }

        internal int Alterar(PlanoEnt obj)
        {
            using (SqlConnection Con = new SqlConnection())
            {
                Con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();

                Cmd.CommandText = "spAlterar";
                Cmd.Parameters.Add("IdPlano", SqlDbType.Int).Value = obj.IdPlano;
                Cmd.Parameters.Add("Data", SqlDbType.DateTime).Value = obj.Data;
                Cmd.Parameters.Add("Hora", SqlDbType.VarChar).Value = obj.Hora;
                Cmd.Parameters.Add("Eixo", SqlDbType.VarChar).Value = obj.Eixo;
                Cmd.Parameters.Add("Objetivo", SqlDbType.VarChar).Value = obj.Objetivo;
                Cmd.Parameters.Add("Conteudo", SqlDbType.VarChar).Value = obj.Conteudo;
                Cmd.Parameters.Add("Metodologia", SqlDbType.VarChar).Value = obj.Metodologia;
                Cmd.Parameters.Add("Avaliacao", SqlDbType.VarChar).Value = obj.Avaliacao;

                Cmd.Connection = Con;

                //executar o comando c/ retorno(int qtd)
                int qtd = Cmd.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        internal int Excluir(PlanoEnt obj)
        {
            using (SqlConnection Con = new SqlConnection())
            {
                Con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                Cmd.CommandText = "Excluir";
                Cmd.Parameters.Add("IdPlano", SqlDbType.Int).Value = obj.IdPlano;
                Cmd.Connection = Con;

                //executar o comando c/ retorno(int qtd)
                int qtd = Cmd.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        internal int Inserir(PlanoEnt obj)
        {
            using (SqlConnection Con = new SqlConnection())
            {
                Con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                Cmd.CommandText = "spInserir";
               
                Cmd.Parameters.Add("Data", SqlDbType.DateTime).Value = obj.Data;
                Cmd.Parameters.Add("Hora", SqlDbType.VarChar).Value = obj.Hora;
                Cmd.Parameters.Add("Eixo", SqlDbType.VarChar).Value = obj.Eixo;
                Cmd.Parameters.Add("Objetivo", SqlDbType.VarChar).Value = obj.Objetivo;
                Cmd.Parameters.Add("Conteudo", SqlDbType.VarChar).Value = obj.Conteudo;
                Cmd.Parameters.Add("Metodologia", SqlDbType.VarChar).Value = obj.Metodologia;
                Cmd.Parameters.Add("Avaliacao", SqlDbType.VarChar).Value = obj.Avaliacao;

                Cmd.Connection = Con;

                //executar o comando c/ retorno(int qtd)
                int qtd = Cmd.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }
    }
}
