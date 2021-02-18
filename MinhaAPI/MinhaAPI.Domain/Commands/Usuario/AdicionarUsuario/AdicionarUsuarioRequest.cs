using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaAPI.Domain.Commands.Usuario
{
    public class AdicionarUsuarioRequest : IRequest<string>
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

    }
}
