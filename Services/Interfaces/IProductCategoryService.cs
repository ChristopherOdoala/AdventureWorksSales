using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdventureWorksSales.Models;

namespace AdventureWorksSales.Web.Services.Interfaces
{
    public interface IProductCategoryService
    {
        IEnumerable<ProductCategory> GetAllProductCategories(int? PageIndex, int? PageSize);
        ProductCategory GetProductCategoryById(int Id);
    }
}