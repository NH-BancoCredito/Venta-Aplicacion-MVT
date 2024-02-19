using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Venta.Domain.Models;
using Venta.Domain.Services.WebServices;

namespace Venta.Infrastructure.Services.WebServices
{
    public class PagoService : IPagoService
    {
        private readonly HttpClient _httpClientPagos;
        public PagoService(HttpClient httpClientPagos)
        {
            _httpClientPagos = httpClientPagos;
        }

        public async Task<bool> RealizarPago(Pago pago)
        {
            //using var request = new HttpRequestMessage(HttpMethod.Put, "api/pagos/realizarPago");

            //var entidadSerializada = JsonSerializer.Serialize(new { Pago = pago });
            //request.Content = new StringContent(entidadSerializada, Encoding.UTF8, MediaTypeNames.Application.Json);

            //var response = await _httpClientPagos.SendAsync(request);

            //return response.IsSuccessStatusCode;

            HttpResponseMessage response = await _httpClientPagos.PutAsJsonAsync("api/pagos/realizarPago", pago);
            response.EnsureSuccessStatusCode();            

            // return URI of the created resource.
            return response.IsSuccessStatusCode;
        }
    }
}
