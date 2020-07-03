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
    public partial class frm_Consultas : Form
    {
        cl_Contato cont = new cl_Contato();

        cl_ControleContato controle = new cl_ControleContato();

        public frm_Consultas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxBusca.SelectedIndex == 0)
            {
                try
                {
                    int codigo = Convert.ToInt32(txtOpcao.Text);

                    dgvBusca.DataSource = controle.pesquisaCodigo(codigo);
                }
                catch
                {
                    MessageBox.Show("Digite um valor inteiro para código!");
                    txtOpcao.Clear();
                    txtOpcao.Focus();
                }
            }
            else if (cbxBusca.SelectedIndex == 1)
            {
                try
                {
                    string nome = Convert.ToString(txtOpcao.Text);

                    dgvBusca.DataSource = controle.pesquisaNome(nome);
                }
                catch
                {
                    MessageBox.Show("Digite o nome assim como foi registrado!");
                    txtOpcao.Clear();
                    txtOpcao.Focus();
                }
            }
            else if (cbxBusca.SelectedIndex == 2)
            {
                try
                {
                    string telefone = Convert.ToString(txtOpcao.Text);

                    dgvBusca.DataSource = controle.pesquisaTelefone(telefone);
                }
                catch
                {
                    MessageBox.Show("Digite o telefone assim como foi registrado!");
                    txtOpcao.Clear();
                    txtOpcao.Focus();
                }
            }
            else if (cbxBusca.SelectedIndex == 3)
            {
                try
                {
                    string celular = Convert.ToString(txtOpcao.Text);

                    dgvBusca.DataSource = controle.pesquisaCelular(celular);
                }
                catch
                {
                    MessageBox.Show("Digite o número de celular assim como foi registrado!");
                    txtOpcao.Clear();
                    txtOpcao.Focus();
                }
            }
            else if (cbxBusca.SelectedIndex == 4)
            {
                try
                {
                    string email = Convert.ToString(txtOpcao.Text);

                    dgvBusca.DataSource = controle.pesquisaEmail(email);
                }
                catch
                {
                    MessageBox.Show("Digite o email assim como foi registrado!");
                    txtOpcao.Clear();
                    txtOpcao.Focus();
                }
            }
        }

        private void cbxBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBusca.SelectedIndex < 0)
            {
                txtOpcao.Enabled = false;
                btnBuscar.Enabled = false;
                lblOpcao.Text = "";
            }
            else
            {
                txtOpcao.Enabled = true;
                lblOpcao.Text = "Digite o " + cbxBusca.Text;
                txtOpcao.Clear();
                txtOpcao.Focus();
            }
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            dgvBusca.DataSource = controle.PreencherTodos(); // É referenciado como DataSource as informãções pertencentes ao método PreencherTodos que está na classe ControleContato aqui referenciada como controle
        }

        private void txtOpcao_TextChanged(object sender, EventArgs e)
        {
            if(txtOpcao.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }
    }
}
