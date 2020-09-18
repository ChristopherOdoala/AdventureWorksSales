using AdventureWorksSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using AdventureWorksSales.Web.Services.Interfaces;
using System.Web;
using AdventureWorksSales.Utils;

namespace AdventureWorksSales.Services
{
    public class ProductCategoryService : EntityRepository<ProductCategory>, IProductCategoryService
    {
        private AWSDbContext _ctx;
        public ProductCategoryService(AWSDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<ProductCategory> GetAllProductCategories(int? PageIndex, int? PageSize)
        {
            var pageSize = PageSize == null || PageSize < 1 ? 10 : PageSize.Value;
            var pageIndex = PageIndex == null || PageIndex < 1 ? 1 : PageIndex.Value;
            var res = GetAll().Paginate(pageIndex, pageSize);
            return res;
        }

        public ProductCategory GetProductCategoryById(int Id)
        {
            return GetAll().Where(x => x.ProductCategoryID == Id).FirstOrDefault();
        }
    }
}