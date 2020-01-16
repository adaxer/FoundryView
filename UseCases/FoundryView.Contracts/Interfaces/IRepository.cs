﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FoundryView.UseCases.Contracts.Models;

namespace FoundryView.UseCases.Contracts.Interfaces
{
    public interface IRepository<T> where T : ModelBase
    {
        Task<T> AddOrUpdate(T entity);

        Task<bool> Delete(T entity);

        Task<IEnumerable<T>> FindAll();

        Task<T> FindById(int id);
    }

}
