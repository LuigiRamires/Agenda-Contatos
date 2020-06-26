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
            txtCodigo.Clear();
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
            if (txtNome.Text != "" && txtTelefone.Text != "" && txtCelular.Text != "" && txtEmail.Text != "")
            {
                cont.Nome = txtNome.Text;
                cont.Telefone = txtTelefone.Text;
                cont.Celular = txtCelular.Text;
                cont.Email = txtEmail.Text;

                limpar();
                MessageBox.Show(controle.cadastrar(cont));
            }
            else
            {
                MessageBox.Show("Olá, parece que temos um problema!!\nInsira as informações em todos os campos para efetuar seu cadastro.\nObrigado desde já!", "ATENÇÃO - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNome.Text != "" && txtTelefone.Text != "" && txtCelular.Text != "" && txtEmail.Text != "")
            {
                cont.Codcontato = int.Parse(txtCodigo.Text);
                cont.Nome = txtNome.Text;
                cont.Nome = txtNome.Text;
                cont.Telefone = txtTelefone.Text;
                cont.Celular = txtCelular.Text;
                cont.Email = txtEmail.Text;

                limpar();
                MessageBox.Show(controle.alterar(cont));
            }
            else
            {
                MessageBox.Show("Olá, parece que temos um problema!!\n\nInsira as informações em todos os campos para efetuar a alteração no seu registro.\n\n\n PS* Não esqueça de informar o código!!\n\nObrigado desde já!", "ATENÇÃO - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // SE O TEXTO NO TEXTBOX DO CÓDIGO ESTIVER DIFERENTE DE VAZIO ENTÃO
            if (txtCodigo.Text != "")
            {
                // CONVERSÃO DE STRING PARA INTEIRO
                cont.Codcontato = int.Parse(txtCodigo.Text);
                
                // CHAMA O MÉTODO QUE LIMA OS CAMPOS DE TEXTO
                limpar();
                // PASSA A CONFIRMAÇÃO DE REGISTRO DELETADO
                MessageBox.Show(controle.deletar(cont));
            }
            else
            {
                // SENÃO ESSE MESSAGEBOX APARECE FALANDO QUE PRECISA SER DIGITADO O CÓDIGO PARA A EXCLUSÃO
                MessageBox.Show("Olá, parece que temos um problema!!\n\nINSIRA O CÓDIGO PARA EXCLUIR O REGISTRO.\n\n\n Obrigado desde já!", "ATENÇÃO - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
