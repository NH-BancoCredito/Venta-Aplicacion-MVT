using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Venta.Domain.Models;

namespace Venta.Application.CasosUso.AdministrarPago.RealizarPago
{
    public class RealizarPagoMapper : Profile
    {
        public RealizarPagoMapper()
        {
            CreateMap<RealizarPagoRequest, Models.Pago>();
                //.ForMember(dest => dest.Detalle, map => map.MapFrom(src => src.Productos));

            //CreateMap<RegistrarVentaDetalleRequest, Models.VentaDetalle>();
        }
    }
}
