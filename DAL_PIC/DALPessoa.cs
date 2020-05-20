using MODELO_PIC;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PIC
{
    public class DALPessoa
    {
        private DALConexao conexao;

        public DALPessoa(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(MODELOPessoas modelo)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO PESSOA (id, nome, sexo, datanascimento, endereco, email, cpf, telefone)" +
                "VALUES (NULL , @nome, @sexo, @dt, @endereco, @email, @cpf, @telefone);";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@sexo", modelo.Sexo);
            cmd.Parameters.AddWithValue("@dt", modelo.Nascimentohelp);
            cmd.Parameters.AddWithValue("@enderco", modelo.Enderco);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);


            cmd.Connection = this.conexao.objConexao;
            conexao.Conectar();
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            modelo.Id = id;

            conexao.Desconectar();

        }
    }
}