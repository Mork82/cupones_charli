using cuponesCharli.Back.Modelos;
using cuponesCharli.Back.Persitencia;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace cuponesCharli.Back.App
{
    public class ConsultaCupon
    {
        public class CuponUnico : IRequest<Codigos>
        {
            public int codigoCorrecto { get; set; }
        }
        public class Manejador : IRequestHandler<CuponUnico, Codigos>
        {
            private readonly CodigosContext _context;

            public Manejador(CodigosContext context)
            {
                _context = context;

            }

            public async Task<Codigos> Handle(CuponUnico request, CancellationToken cancellationToken)
            {
                var cupon = await _context.Codigos.Where(x => x.Codigo == request.codigoCorrecto).FirstOrDefaultAsync();

                if (cupon == null)
                {
                    throw new Exception("El cupon no ha sido premiado ");
                };
                return cupon;

            }
        }
    }
}
