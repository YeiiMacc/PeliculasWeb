﻿using PeliculasWeb.Models;
using PeliculasWeb.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PeliculasWeb.Repositorio
{
    public class UsuarioRepositorio : Repositorio<UsuarioU>, IUsuarioRepositorio
    {
        //Inyeccion de dependencias se debe importar el IHttpClientFactory
        private readonly IHttpClientFactory _clientFactory;

        public UsuarioRepositorio(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
    }
}
