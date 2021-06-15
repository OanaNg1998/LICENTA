using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.OrderHistoryService
{
    public interface IOrderHistoryService
    {
        public Task<bool>  MakeOrderAsync(OrderData data);
    }
}
