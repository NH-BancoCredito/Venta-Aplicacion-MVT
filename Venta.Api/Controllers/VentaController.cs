using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Venta.Application.CasosUso.AdministrarPago.RealizarPago;
using Venta.Application.CasosUso.AdministrarProductos.ConsultarProductos;

namespace Venta.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class VentaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public VentaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("registrar")]
        public async Task<IActionResult> Registrar([FromBody] RealizarPagoRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
