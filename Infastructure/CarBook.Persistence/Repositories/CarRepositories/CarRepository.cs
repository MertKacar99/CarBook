﻿using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entitites;

namespace CarBook.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrands()
        {
           var values = _context.Cars.Include(x=> x.Brand).ToList();
            return values;
        }

        public List<Car> GetLast5CarsWithBrands()
        {
            var values = _context.Cars.Include(_x => _x.Brand).Take(5).OrderByDescending(x => x.CarID).Take(5).ToList();
            return values;
        }
    }
}
