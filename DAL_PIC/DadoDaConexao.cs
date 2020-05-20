using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PIC
{
    public class DadoDaConexao
    {
        private string server = "remotemysql.com";
        private string port = "3306";
        private string user = "nPq2IsXovm";
        private string pass = "XEqkMhZAJ2";
        private string database = "nPq2IsXovm";

        public string StringDeConexao
        {

            get
            {
                return "server = " + this.server + ";" +
                    "port = " + this.port + ";" +
                    "user = " + this.user + ";" +
                    "pass = " + this.pass + ";" +
                    "database =  " + this.database + ";";
            }

        }

    }
}
