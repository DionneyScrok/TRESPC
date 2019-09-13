using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Menu
{
    class Cadastro
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

         public Cadastro(string id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }

    }
}
