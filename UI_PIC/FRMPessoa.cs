using DAL_PIC;
using BLL_PIC;
using MODELO_PIC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pic
{
    public partial class FRMPessoa : Form
    {
        public FRMPessoa()
        {
            InitializeComponent();
        }

        private void BTNINSERIR_Click(object sender, EventArgs e)
        {
            DadoDaConexao dc = new DadoDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLPessoa bllpessoa = new BLLPessoa(cx);

            MODELOPessoas modelopessoa = new MODELOPessoas();
            modelopessoa.Nome = TXTNOME.Text;
            modelopessoa.Sexo = TXTSEXO.Text;
            modelopessoa.Nascimentohelp = new DateTime(DATENAS.Value.Year,
                DATENAS.Value.Month,
                DATENAS.Value.Day);
            modelopessoa.Enderco = TXTEND.Text;
            modelopessoa.Email = TXTEMAIL.Text;
            modelopessoa.Cpf = TXTCPF.Text;
            modelopessoa.Telefone = TXTTEL.Text;


           string retorno = bllpessoa.Incluir(modelopessoa);
            MessageBox.Show(retorno);
        }
    }
}
