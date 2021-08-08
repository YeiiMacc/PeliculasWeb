using Microsoft.AspNetCore.Mvc;
using PeliculasWeb.Models;
using PeliculasWeb.Repositorio.IRepositorio;
using PeliculasWeb.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasWeb.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaRepositorio _repoCategoria;
        public CategoriasController(ICategoriaRepositorio repoCategoria)
        {
            _repoCategoria = repoCategoria;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Categoria() { });
        }

        [HttpGet]
        public async Task<IActionResult> GetTodasCategorias()
        {
            return Json(new { data = await _repoCategoria.GetTodoAsync(Constantes.RutaCategoriasApi)});
        }

    }
}
