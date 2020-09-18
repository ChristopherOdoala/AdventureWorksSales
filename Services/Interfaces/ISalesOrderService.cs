using AdventureWorksSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorksSales.Web.Services.Interfaces
{
    public interface ISalesOrderService
    {
        IEnumerable<SalesOrder> GetAllSalesOrder();

    }
}