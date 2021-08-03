using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasWeb.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T: class
    {
        Task<IEnumerable> GetTodoAsync(string url);
        Task<T> GetAsync(string url, int Id);
        Task<bool> CrearAsync(string url, T itemActualizar);
        Task<bool> ActualizarAsync(string url, T itemActualizar);
        Task<bool> BorrarAsync(string url, int id);
    }
}
