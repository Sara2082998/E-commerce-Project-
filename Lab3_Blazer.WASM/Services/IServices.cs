﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab3_Blazer.WASM.Services
{
    public interface IServices<T>
    {

        Task<List<T>> GetAll();
        Task<T> GetByID(int id);
        Task Insert(T item);
        Task Update(int id, T item);
        Task Delete(int id);
    }
}
