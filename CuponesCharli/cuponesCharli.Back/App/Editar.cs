using cuponesCharli.Back.Persitencia;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace cuponesCharli.Back.App
{
    public class Editar

    {
        public class Insertar : IRequest
        {
            public int? CodigoCupon { get; set; }
            public int? Usuario { get; set; }
            public DateTime? FechaAsignacion { get; set; }

        }

        public class Manejador : IRequestHandler<Insertar>
        {
            private readonly CodigosContext _context;


            public Manejador(CodigosContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Insertar request, CancellationToken cancellationToken)
            {
                var cupon = await _context.Codigos.FindAsync(request.CodigoCupon);

                return Unit.Value;
            }
        }
    }
}
