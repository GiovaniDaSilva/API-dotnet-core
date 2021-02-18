using MediatR;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaAPI.Domain.Commands.Usuario.ListarUsuarios
{
    public class ListarUsuarioHandler : IRequestHandler<ListarUsuarioRequest, object>
    {
        public async Task<object> Handle(ListarUsuarioRequest request, CancellationToken cancellationToken)
        {

            Collection<Entities.Usuario> listaUsuario = new Collection<Entities.Usuario>();   
            listaUsuario.Add(new Entities.Usuario("Giovani da Silva", "giovani.silva", "12345"));

            listaUsuario.Add(new Entities.Usuario("Dayana Raymundo", "dayana.raymundo", "101010"));

            listaUsuario.Add(new Entities.Usuario("Roni da Silva", "roni.silva", "12232"));

            return await Task.FromResult(listaUsuario);
        }
    }
}
