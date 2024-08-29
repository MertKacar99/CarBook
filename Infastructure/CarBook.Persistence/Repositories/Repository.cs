using CarBook.Application.Interfaces;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
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
        private readonly CarBookContext _carBookContext;

        public Repository(CarBookContext carBookContext)
        {
            _carBookContext = carBookContext;
        }

        public async Task CreateAsync(T entity)
        {
            _carBookContext.Set<T>().Add(entity);
            await _carBookContext.SaveChangesAsync();
        }

      
        public Task<List<T>> GetAllAsync()
        {
            return _carBookContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
          
            return await _carBookContext.Set<T>().FindAsync(id);
              
               
        }

        public async Task RemoveAsync(T entity)
        {
           _carBookContext.Set<T>().Remove(entity);
            await _carBookContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _carBookContext.Set<T>().Update(entity);
            await _carBookContext.SaveChangesAsync();
        }
    }
}
