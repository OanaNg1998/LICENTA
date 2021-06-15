import { OrderProduct } from "./OrderProduct";

export class OrderData {
  Name: string;
  Email: string;
  Products: Array<OrderProduct> = new Array();
}
