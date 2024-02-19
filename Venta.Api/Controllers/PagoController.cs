using MediatR;
using Microsoft.AspNetCore.Mvc;
using Venta.Application.CasosUso.AdministrarPago.RealizarPago;

namespace Venta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]

    public class PagoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PagoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("realizarPago")]
        public async Task<IActionResult> RealizarPago([FromBody] RealizarPagoRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
