using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdventureWorksSales.Models;

namespace AdventureWorksSales.Web.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
    }
}