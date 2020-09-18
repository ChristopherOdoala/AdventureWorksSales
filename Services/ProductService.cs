using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdventureWorksSales.Web.Services.Interfaces;
using AdventureWorksSales.Models;
using AdventureWorksSales.Utils;

namespace AdventureWorksSales.Web.Services
{
    public class ProductService : EntityRepository<Product>, IProductService
    {
        private AWSDbContext _ctx;
        public ProductService(AWSDbContext ctx):base(ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return GetAll();
        }

        public Product GetProductById(int Id)
        {
            return GetAll().Where(x => x.ProductID == Id).FirstOrDefault();
        }
    }
}