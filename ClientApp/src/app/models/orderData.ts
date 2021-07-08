import { OrderProduct } from "./OrderProduct";

export class OrderData {
  Name: string;
  Email: string;
  PhoneNumber: string;
  DeliveryAddress: string;
  AppliedVoucher: boolean;
  Products: Array<OrderProduct> = new Array();
}
