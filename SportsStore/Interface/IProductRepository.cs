﻿using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Interface
{
    public interface IProductRepository
    {
        //IEnumerable<Product> Products { get;  }

        IQueryable<Product> Products { get; }
    }
}
