using cuponesCharli.Back.App;
using cuponesCharli.Back.Modelos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace cuponesCharli.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuponesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CuponesController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpGet("{codigo}")]
        public async Task <ActionResult<Codigos>> GetCupon(int codigo) {

            return await _mediator.Send(new ConsultaCupon.CuponUnico { codigoCorrecto = codigo}); 
        }
    }
}
