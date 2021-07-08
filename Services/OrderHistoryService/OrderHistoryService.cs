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
            int totalPrice = 0;
            foreach (OrderProduct products in data.Products)
            {
                totalPrice = totalPrice + products.Price * int.Parse(products.Quantity);

            }
            int saleTotal = totalPrice - (25 * totalPrice) / 100;
                foreach ( OrderProduct products in data.Products)
            {

                OrderHistory order = new OrderHistory
                {
                    Id = Guid.NewGuid().ToString(),
                    OrderId = orderId,
                    CompleteName = data.Name,
                    EmailAddress = data.Email,
                    EquipmentId = products.Id,
                    ProductQuantity = products.Quantity,
                    DeliveryAddress = data.DeliveryAddress,
                    TotalPrice = totalPrice,
                    
                   


                };
                _orderHistoryRepository.Create(order);
            }
           
            string tableContent="";
            string tableHead = "<table><tr><th>Product Name</th><th></th><th>Measure</th><th>Quantity</th><th>Price</th></tr>";
            string tableEnd = "</table>";
            string totalTableVoucherPrice = "<br></br><br></br><table><tr><th></th><th>Total Price</th></tr>" +
                "<tr><td>TOTAL ORDER</td><td>" + totalPrice.ToString() + " RON" + "</td></tr><tr><td>-25% OFF VOUCHER</td><td>"+saleTotal+" RON"+"</td></tr><tr><td>EXPRESS COURIER DELIVERY</td><td> 10 RON </td></tr><tr><td>TOTAL ORDER VALUE</td><td>" + (saleTotal + 10).ToString() + " RON" + "</td></tr></table>";
            string totalTablePrice = "<br></br><br></br><table><tr><th></th><th>Total Price</th></tr><tr><td>EXPRESS COURIER DELIVERY</td><td> 10 RON </td></tr>" +
                "<tr><td>TOTAL ORDER</td><td>" + totalPrice.ToString() +" RON"+ "</td></tr><tr><td>TOTAL ORDER VALUE</td><td>" + (totalPrice + 10).ToString()+" RON" + "</td></tr></table>";
            string details = "<br></br><br></br>Your products will be delivered in a maximum of 2-3 working days by express courier." +
                "<br></br><br></br>" + "The order was registered in the name of " + data.Name + " and the delivery address is " + data.DeliveryAddress
                + "." + "<br></br><br></br>" + "Before delivery, the courier will contact you at the number " + data.PhoneNumber+"."+
                "<br></br><br></br>"+ "Do not hesitate to contact us in case of any questions or problems, thank you for the order you  made on our site, "
                + "<br></br><br></br>"+"Just Move Team .";

            foreach (OrderProduct products in data.Products)
            {
                tableContent =tableContent+"<tr><td>" + products.Name + "</td>" + "<td>" + "<p><img src='" + products.Image + "'</p> " + "</td>" + "<td> "
                      + products.Measure + "</td>" + "<td> " + products.Quantity + "</td>" + "<td> " + products.Price +" RON"+ "</td></tr>";
            }
            if (data.AppliedVoucher == true)
            {
                string message = "Dear " + data.Name + ", your order on our website has been registered." + "<br></br><br></br>" + "Your order summary is:" + "<br></br><br></br>" + tableHead + tableContent + tableEnd + totalTableVoucherPrice + details;
                await _emailSender.SendEmailAsync(data.Email/*"oana_neagu98@yahoo.com"*/, "Order Confirmation",
                         message);
            }
                else
            {
                string message = "Dear " + data.Name + ", your order on our website has been registered." + "<br></br><br></br>" + "Your order summary is:" + "<br></br><br></br>" + tableHead + tableContent + tableEnd + totalTablePrice + details;
                await _emailSender.SendEmailAsync(data.Email/*"oana_neagu98@yahoo.com"*/, "Order Confirmation",
                         message);
            }
          


          

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
