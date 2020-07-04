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
    public partial class frmRelatório : Form
    {
        public frmRelatório()
        {
            InitializeComponent();
        }

        private void frmRelatório_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaDataSet.tb_contato'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contatoTableAdapter.Fill(this.agendaDataSet.tb_contato);

            this.rpvContatos.RefreshReport();
        }
    }
}
