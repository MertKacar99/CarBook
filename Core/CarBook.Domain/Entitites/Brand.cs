﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entitites
{
    public class Brand
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; }


    }
}
