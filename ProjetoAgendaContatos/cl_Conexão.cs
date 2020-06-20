using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ProjetoAgendaContatos
{
    class cl_Conexão
    {
        // CRIAÇÃO DA CONEXÃO COM O BANCO DE DADOS      |  (IP DO SERVIDOR; PORTA DO SERVIDOR; NOME DO BANCO DE DADOS; USUÁRIO UTILIZADO; SENHA)
        public MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=agenda;User=root;Pwd=1234");

        // CRIAÇÃO DO MÉTODO CONECTAR: ELE VAI ABRIR O BANCO DE DADOS -> SE CONSEGUIR VAI APARECER QUE CONECTOU SENÃO VAI APARECER O ERRO QUE DEU
        public string conectar()
        {
            try
            {
                con.Open();
                return ("Conexão realizada com sucesso!");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }

        // CRIAÇÃO DO MÉTODO DESCONECTAR: ELE VAI FECHAR O BANCO DE DADOS -> SE CONSEGUIR VAI APARECER QUE DESCONECTOU SENÃO VAI APARECER O ERRO QUE DEU
        public string desconectar()
        {
            try
            {
                con.Close();
                return ("Conexão encerrada!");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }
    }
}
