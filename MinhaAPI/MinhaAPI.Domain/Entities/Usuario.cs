using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaAPI.Domain.Entities
{
    public class Usuario
    {
        public Usuario(string nome, string login, string senha)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
        }

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
