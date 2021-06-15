using JUSTMOVE.Models;
using JUSTMOVE.Repositories.OrderHistoryRepository;
using JUSTMOVE.Services.EmailSender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.OrderHistoryService
{
    public class OrderHistoryService :  IOrderHistoryService
    {
        private readonly IOrderHistoryRepository _orderHistoryRepository;
        private readonly IEmailSender _emailSender;
        public OrderHistoryService(IOrderHistoryRepository orderHistoryRepository, IEmailSender emailSender)
        {
            _orderHistoryRepository = orderHistoryRepository;
            _emailSender = emailSender;



        }
        public async Task<bool> MakeOrderAsync(/*string name, string emailAddress*/OrderData data)
        {
            //OrderData: oana@yahoo.com, adresa, [{id=1], {id=4}], quantity
            bool isCreated = true;
            /*
             * 
             * 
             *
             String orderId = Guid.NewGuid().ToString();
             MakeOder(OrderData data){
                foreach(products in data.products){

                    OrderHistory order = new OrderHistory
            {
                Id = Guid.NewGuid().ToString(),
                OrderId = orderId,
                CompleteName = DATA.name,
                EmailAddress = emailAddress,
               EquipmentId = products.id,
               Quantity = products.quantity
               

            };
            _orderHistoryRepository.Create(order);
            }
            }
             */
            String orderId = Guid.NewGuid().ToString();
            foreach ( OrderProduct products in data.Products)
            {
                OrderHistory order = new OrderHistory
                {
                    Id = Guid.NewGuid().ToString(),
                    OrderId = orderId,
                    CompleteName = data.Name,
                    EmailAddress = data.Email,
                    EquipmentId = products.Id,
                    ProductQuantity=products.Quantity,
                    
                   


                };
                _orderHistoryRepository.Create(order);
            }
           string message = "Comanda dvs este:";
           await _emailSender.SendEmailAsync(data.Email/*"oana_neagu98@yahoo.com"*/, "Discount",
                      message);



            /*  OrderHistory order = new OrderHistory
                  {
                      Id = Guid.NewGuid().ToString(),

                      CompleteName = name,

                      EmailAddress = emailAddress


                  };
                  _orderHistoryRepository.Create(order);*/



            return isCreated;
        }
    }
}
