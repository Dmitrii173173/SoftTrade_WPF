﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crud.domain.Services
{
    public interface IDataServices<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<bool> Delete(T entity);
        Task<T> Update(T entity);
    }
}
