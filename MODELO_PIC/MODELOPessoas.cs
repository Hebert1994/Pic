using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*Classe referente a tabela do banco de dados*/

namespace MODELO_PIC
{
    /*Classe referente a pessoa para indicar outra*/
    public class MODELOPessoas
    {

        /*Atributos_Help*/

        private int id;
        private string nome;
        private string sexo;
        private DateTime nascimentohelp;
        private string enderco;
        private string email;
        private string cpf;
        private string telefone;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public string Sexo
        {
            get => sexo;
            set => sexo = value;
        }
        public DateTime Nascimentohelp
        {
            get => nascimentohelp;
            set => nascimentohelp = value;
        }
        public string Enderco
        {
            get => enderco;
            set => enderco = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Cpf
        {
            get => cpf;
            set => cpf = value;
        }
        public string Telefone
        {
            get => telefone;
            set => telefone = value;
        }

    }
}