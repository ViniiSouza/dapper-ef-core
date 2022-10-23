﻿using DapperEFCoreAPI.Application.Interfaces;
using DapperEFCoreAPI.Domain;
using DapperEFCoreAPI.Infra.Interfaces;

namespace DapperEFCoreAPI.Application.Services
{
    public class ProdutoAppService : ServiceAppBase<Produto>, IProdutoAppService
    {
        public ProdutoAppService(IRepository<Produto> repository) : base(repository)
        {
        }
    }
}