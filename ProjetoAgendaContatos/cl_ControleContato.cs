﻿using MySql.Data.MySqlClient;
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
    }
}
