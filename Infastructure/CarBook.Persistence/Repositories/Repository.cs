using CarBook.Application.Interfaces;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        

        Task IRepository<T>.CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<T>> IRepository<T>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
