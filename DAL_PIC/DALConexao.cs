using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DAL_PIC
{
    public class DALConexao
    {

        private string strConexao;
        private MySqlConnection conexao;

        public DALConexao(string DadosConexao)
        {
            this.conexao = new MySqlConnection();
            this.strConexao = DadosConexao;
            conexao.ConnectionString = DadosConexao;
        }

        public MySqlConnection objConexao
        {
            get { return this.conexao; }
            set { this.conexao = value; }

        }

        public void Conectar()
        {
            this.conexao.Open();
        }

        public void Desconectar()
        {
            this.conexao.Close();
        }
    }


}
