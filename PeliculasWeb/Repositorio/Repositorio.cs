using Newtonsoft.Json;
using PeliculasWeb.Repositorio.IRepositorio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasWeb.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        //Clase que Implementa el Repositorios

        // Inyeccion de dependencias se debe implementar el IHttpClientFactory
        private readonly IHttpClientFactory _clientFactory;
        public Repositorio(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<bool> ActualizarAsync(string url, T itemActualizar)
        {
            var peticion = new HttpRequestMessage(HttpMethod.Patch, url);

            if (itemActualizar != null)
            {
                peticion.Content = new StringContent(
                    JsonConvert.SerializeObject(itemActualizar), Encoding.UTF8, "application/json"
                    );
            }
            else
            {
                return false;
            }

            var cliente = _clientFactory.CreateClient();
            HttpResponseMessage respuesta = await cliente.SendAsync(peticion);

            // Validar si se actualizop y retorna boleano
            if (respuesta.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Task<bool> BorrarAsync(string url, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CrearAsync(string url, T itemActualizar)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(string url, int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable> GetTodoAsync(string url)
        {
            throw new NotImplementedException();
        }
    }
}
