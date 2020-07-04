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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Passa para o paramêtro que o valor buscar do controle está no textBox Código
                cont = controle.buscar(int.Parse(txtCodigo.Text));
                // Se cont é nulo então mostra-se uma messageBox
                if(cont is null)
                {
                    MessageBox.Show("Registro não encontrado");
                    limpar();
                }
                // Senão serão atribuídos esses valores
                else
                {
                    txtCodigo.Text = cont.Codcontato.ToString();
                    txtNome.Text = cont.Nome;
                    txtTelefone.Text = cont.Telefone;
                    txtCelular.Text = cont.Celular;
                    txtEmail.Text = cont.Email;
                }
            }
            // Caso não seja posível executar o código acima será exibido o motivo do erro.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAgenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            // HABILITAR O KEYPREVIEW DO FORMULÁRIO!!!!!!!
            // Condição "if" para quando apertar a tecla enter o foco vá para o próximo item.
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void btnNoturno_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            lblC_MySQL.ForeColor = Color.White;
            lblCodigo.ForeColor = Color.White;
            lblNome.ForeColor = Color.White;
            lblCelular.ForeColor = Color.White;
            lblTelefone.ForeColor = Color.White;
            lblEmail.ForeColor = Color.White;
            btnAlterar.BackColor = Color.Black;
            btnCadastrar.BackColor = Color.Black;
            btnExcluir.BackColor = Color.Black;
            btnBuscar.BackColor = Color.Black;
            btnNoturno.BackColor = Color.Black;
            btnAlterar.ForeColor = Color.White;
            btnCadastrar.ForeColor = Color.White;
            btnExcluir.ForeColor = Color.White;
            btnBuscar.ForeColor = Color.White;
            btnNoturno.ForeColor = Color.White;
            btnNoturno.Visible = false;
            btnDiurno.Visible = true;
        }

        private void btnDiurno_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            lblC_MySQL.ForeColor = Color.Black;
            lblCodigo.ForeColor = Color.Black;
            lblNome.ForeColor = Color.Black;
            lblCelular.ForeColor = Color.Black;
            lblTelefone.ForeColor = Color.Black;
            lblEmail.ForeColor = Color.Black;
            btnAlterar.BackColor = Color.LightGray;
            btnCadastrar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
            btnBuscar.BackColor = Color.LightGray;
            btnNoturno.BackColor = Color.LightGray;
            btnAlterar.ForeColor = Color.Black;
            btnCadastrar.ForeColor = Color.Black;
            btnExcluir.ForeColor = Color.Black;
            btnBuscar.ForeColor = Color.Black;
            btnNoturno.ForeColor = Color.Black;
            btnNoturno.Visible = true;
            btnDiurno.Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frm_Consultas consultas = new frm_Consultas();

            consultas.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatório relatório = new frmRelatório();

            relatório.ShowDialog();
        }
    }
}
