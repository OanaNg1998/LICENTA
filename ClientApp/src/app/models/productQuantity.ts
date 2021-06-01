export class ProductQuantity {
  productId: string;
  quantity: number = 0;

  constructor(productId: string, quantity: number) {
    this.productId = productId;
    this.quantity = quantity;
  }
}
