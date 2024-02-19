using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.Application.CasosUso.AdministrarProductos.ConsultarProductos;
using Venta.Application.Common;

namespace Venta.Application.CasosUso.AdministrarPago.RealizarPago
{
    public class RealizarPagoRequest : IRequest<IResult>
    {

        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public int FormaPago { get; set; }
        public string NumeroTarjeta { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string CVV { get; set; }
        public string NombreTitular { get; set; }
        public int NumeroCuotas { get; set; }


    }

}
