using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaAPI.Domain.Commands.Usuario
{
    public class AdicionarUsuarioHandler : IRequestHandler<AdicionarUsuarioRequest, string>

    {
        public async Task<string> Handle(AdicionarUsuarioRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Adicionou o usuario");

            return await Task.FromResult("Adicionado com Sucesso.");
        }
    }
}
