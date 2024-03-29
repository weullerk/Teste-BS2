﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.SeedWork
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        T Find(int primaryKey);

        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        void Save();
    }
}
