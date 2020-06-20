using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgendaContatos
{
    public partial class frmAgenda : Form
    {
        // CHAMA-SE AS CLASSES E AS INSTÂNCIA COMO OBJETOS NESSE FORMULÁRIO
        cl_Contato cont = new cl_Contato();
        cl_ControleContato controle = new cl_ControleContato();
        
        public frmAgenda()
        {
            InitializeComponent();
        }

        // MÉTODO PARA LIMPAR OS CAMPOS
        public void limpar()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
        }

        // TESTA A CONEXÃO AO BANCO ANTES DE INICIAR O PROJETO
        private void frmAgenda_Load(object sender, EventArgs e)
        {
            cl_Conexão c = new cl_Conexão();
            MessageBox.Show(c.conectar());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cont.Nome = txtNome.Text;
            cont.Telefone = txtTelefone.Text;
            cont.Celular = txtCelular.Text;
            cont.Email = txtEmail.Text;

            limpar();
            MessageBox.Show(controle.cadastrar(cont));
        }
    }
}
