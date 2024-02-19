using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.Application.Common;
using Venta.Domain.Repositories;
using Venta.Domain.Services.WebServices;
using Models = Venta.Domain.Models;

namespace Venta.Application.CasosUso.AdministrarPago.RealizarPago
{
    public class RealizarPagoHandler :
        IRequestHandler<RealizarPagoRequest, IResult>
    {
        //private readonly IVentaRepository _ventaRepository;
        //private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;
        //private readonly IStocksService _stocksService;
        private readonly IPagoService _pagoService;
        private readonly ILogger _logger;

        public RealizarPagoHandler(IMapper mapper,
            IPagoService pagoService, ILogger<RealizarPagoHandler> logger)
        {
            //_ventaRepository = ventaRepository;
            //_productoRepository = productoRepository;
            _mapper = mapper;
            _pagoService = pagoService;
            _logger = logger;
        }

        public async Task<IResult> Handle(RealizarPagoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                IResult response = null;

                //Aplicando el automapper para convertir el objeto Request a venta dominio
                var pago = _mapper.Map<Models.Pago>(request);
                
                var value = await _pagoService.RealizarPago(pago);
                                
                response = new SuccessResult<bool>(value);

                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw ex;
            }
        }


    }
}
