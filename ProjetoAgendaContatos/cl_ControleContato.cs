using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendaContatos
{
    class cl_ControleContato
    {
        // CHAMA A CLASSE DE CONEXÃO PARA PODER USAR OS PARAMETRÔS NESSA CLASE
        cl_Conexão c = new cl_Conexão();

        // CRIA-SE O MÉTODO CADASTRAR - É CRIADO UM OBJETO COM AS INFORMAÇÕES DO CONTATO E QUE PRECISA SE CONECTAR
        public string cadastrar(cl_Contato cont)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_contato (nome, telefone, celular, email) " +
                    "VALUES ('"+ cont.Nome + "','" + cont.Telefone + "', '" + cont.Celular + "', '" + cont.Email +"')", c.con);

                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("Cadastrado com sucesso");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }
    }
}
