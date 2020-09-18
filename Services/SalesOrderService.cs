using AdventureWorksSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdventureWorksSales.Web.Services.Interfaces;
using AdventureWorksSales.Utils;

namespace AdventureWorksSales.Services
{
    public class SalesOrderService : EntityRepository<SalesOrder>, ISalesOrderService
    {
        private AWSDbContext _ctx;
        public SalesOrderService(AWSDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<SalesOrder> GetAllSalesOrder()
        {
            return GetAll();
        }

        public SalesOrder GetSalesOrderById(int Id)
        {
            return GetAllSalesOrder().Where(x => x.SalesOrderID == Id).FirstOrDefault();
        }
    }
}