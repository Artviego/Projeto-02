﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ConexaoDB
    {
        private string conexaoBanco = "Server=localhost; Database=sistema_individual; Uid=root; Pwd=''";

        public MySqlConnection Conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();
            return conexao;
        }
    }
}
