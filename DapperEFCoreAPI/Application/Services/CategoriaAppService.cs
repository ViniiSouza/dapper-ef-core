﻿using DapperEFCoreAPI.Application.Interfaces;
using DapperEFCoreAPI.Domain;
using DapperEFCoreAPI.Infra.Interfaces;

namespace DapperEFCoreAPI.Application.Services
{
    public class CategoriaAppService : ServiceAppBase<Categoria>, ICategoriaAppService
    {
        public CategoriaAppService(IRepository<Categoria> repository) : base(repository)
        {
        }
    }
}