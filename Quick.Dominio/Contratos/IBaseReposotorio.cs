﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quick.Dominio.Contratos
{
    public interface IBaseReposotorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }

    
}
