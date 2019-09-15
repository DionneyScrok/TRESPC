using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Menu
{
    class Cadastro
    {
        private string Id;
        private string Nome;
        private string Telefone;

        public string _ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string _NOME
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string _TELEFONE
        {
            get { return Telefone; }
            set { Telefone = value; }
        }
        public Cadastro(string id, string nome, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;
        }


    }
}
