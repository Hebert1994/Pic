using DAL_PIC;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using MODELO_PIC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BLL_PIC
{
    public class BLLPessoa
    {
        private DALPessoa DALpessoa;

        public BLLPessoa(DALConexao cx)
        {
            this.DALpessoa = new DALPessoa(cx);
        }

        public string Incluir(MODELOPessoas modelopessoa)
        {
            /*Onde vou gerenciar meus dados*/


            if (modelopessoa.Nome == "")
                return "Nome não pode ser nulo";

            DALpessoa.Incluir(modelopessoa);
            return "ok";



        }

    }
}