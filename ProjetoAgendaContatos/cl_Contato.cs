using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendaContatos
{
    class cl_Contato
    {
        // CRIAÇÃO DOS CAMPOS PRIVADOS
        private int codcontato;
        private string nome;
        private string telefone;
        private string celular;
        private string email;

        // CRIAÇÃO DAS PROPRIEDADES [GET, SET] - PEGAR E SETAR DADOS NO BANCO DE DADOS
        
        public int Codcontato
        {
            get { return codcontato; }
            set { codcontato = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
