using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

        public string alterar(cl_Contato cont)
        {
            // Tenta-se fazer esse bloco de código abaixo
            try
            {
                // É inserido o comando que deve ser dado no SQL e logo após é chamado o método de conexão que está na classe de conexão que aqui foi nomeada de C
                MySqlCommand cmd = new MySqlCommand("update tb_contato set nome='" + cont.Nome + "'," + "telefone='" + cont.Telefone + "', celular='" + cont.Celular + "', email='" + cont.Email + "' where codcontato = '" + cont.Codcontato + "' ; ", c.con);

                // Aqui é aberto o banco de dados (USE)
                c.conectar();
                // O comando é executado no SQL com as devidas inserções do usuário
                cmd.ExecuteNonQuery();
                // Aqui é fechado o banco de dados
                c.desconectar();
                // Mensagem retornada ao usuário quando bem sucedido
                return ("Alterado com sucesso");
            }
            // Caso não seja possível fazer é exibido uma mensagem com o erro do SQL
            catch (MySqlException e)
            {
                // Retorna o erro em versão string
                return (e.ToString());
            }
        }

        public string deletar(cl_Contato cont)
        {
            // Tenta-se fazer esse bloco de código abaixo
            try
            {
                // É inserido o comando que deve ser dado no SQL e logo após é chamado o método de conexão que está na classe de conexão que aqui foi nomeada de C
                MySqlCommand cmd = new MySqlCommand("delete from tb_contato where codcontato ='" + cont.Codcontato + "' ; ", c.con);

                // Aqui é aberto o banco de dados (USE)
                c.conectar();
                // O comando é executado no SQL com as devidas inserções do usuário
                cmd.ExecuteNonQuery();
                // Aqui é fechado o banco de dados
                c.desconectar();
                // Mensagem retornada ao usuário quando bem sucedido
                return ("Deletado com sucesso");
            }
            // Caso não seja possível fazer é exibido uma mensagem com o erro do SQL
            catch (MySqlException e)
            {
                // Retorna o erro em versão string
                return (e.ToString());
            }
        }

        public cl_Contato buscar (int codigo)
        {
            // Instancia-se a classe contato ao objeto cont
            cl_Contato cont = new cl_Contato();
            // Tenta-se fazer esse bloco de código abaixo
            try
            {
                // É inserido o comando que deve ser dado no SQL e logo após é chamado o método de conexão que está na classe de conexão que aqui foi nomeada de C
                MySqlCommand cmd = new MySqlCommand("select * from tb_contato where codcontato ='" + codigo + "' ; ", c.con);

                // Aqui é aberto o banco de dados (USE)
                c.conectar();
                // É criado um objeto que foi chamado de objDados e por ele o comando é executado no SQL com as devidas 
                // leituras do código informado pelo usuário.
                MySqlDataReader objDados = cmd.ExecuteReader();

                // Se o comando dado com o código informado não tiver linhas então ele vai retornar um valor nulo
                if (!objDados.HasRows)
                {
                    return null;
                }
                // Senão irá ler o que se pede e será feita a exibição dos conteúdos abaixo
                else
                {
                    objDados.Read();
                    cont.Codcontato = Convert.ToInt32(objDados["codcontato"]);
                    cont.Nome = objDados["nome"].ToString();
                    cont.Telefone = objDados["telefone"].ToString();
                    cont.Celular = objDados["celular"].ToString();
                    cont.Email = objDados["email"].ToString();

                    // É encerrada a ação do objeto e então retorna os valores
                    objDados.Close();
                    return cont;
                }
            }
            // Caso não seja possível fazer é exibido uma mensagem com o erro do SQL
            catch (MySqlException e)
            {
                // Retorna o erro em versão string
                throw (e);
            }
            finally
            {
                // É o banco é desusado pelo sistema.
                c.desconectar();
            }
        }

        public DataTable PreencherTodos()
        {
            string sql = "select codcontato as 'CÓDIGO', nome as 'NOME', telefone as 'TELEFONE', celular as 'CELULAR', email as 'EMAIL' from tb_contato;";
            // STRING de seleção padrão do SQL 

            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            // Lê o código e também conecta ao banco

            // (USE) no banco
            c.conectar();

            // Converte o comando SQL escrito aqui para ser usado no SQL mesmo
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            // Cria-se o objeto para mostrar no DataGridView
            DataTable contato = new DataTable();
            // Coloca o conteúdo no contato
            da.Fill(contato);
            // Desusa o banco
            c.desconectar();
            // Retorna o resultado encontrado
            return contato;
        }

        public DataTable pesquisaCodigo(int codigo)
        {
            string sql = "select codcontato as 'CÓDIGO', nome as 'NOME', telefone as 'TELEFONE', celular as 'CELULAR', email as 'EMAIL' from tb_contato where codcontato = " + codigo + ";";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisaNome(string nome)
        {
            string sql = "select codcontato as 'CÓDIGO', nome as 'NOME', telefone as 'TELEFONE', celular as 'CELULAR', email as 'EMAIL' from tb_contato where nome like '%" + nome + "%';";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisaTelefone(string telefone)
        {
            string sql = "select codcontato as 'CÓDIGO', nome as 'NOME', telefone as 'TELEFONE', celular as 'CELULAR', email as 'EMAIL' from tb_contato where telefone like '%" + telefone + "%';";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisaCelular(string celular)
        {
            string sql = "select codcontato as 'CÓDIGO', nome as 'NOME', telefone as 'TELEFONE', celular as 'CELULAR', email as 'EMAIL' from tb_contato where celular like '%" + celular + "%';";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisaEmail(string email)
        {
            string sql = "select codcontato as 'CÓDIGO', nome as 'NOME', telefone as 'TELEFONE', celular as 'CELULAR', email as 'EMAIL' from tb_contato where email like '%" + email + "%';";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }
    }
}
