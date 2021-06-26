import { EventEmitter, ViewChild } from '@angular/core';
import { Output } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { CartService } from '../../../cart.service';
import { Equipment } from '../../../models/equipment';
import { OrderData } from '../../../models/orderData';
import { OrderProduct } from '../../../models/OrderProduct';
import { ShopItems } from '../../../models/shopItems';
import { ScanqrcodemodalComponent } from './scanqrcodemodal/scanqrcodemodal.component';


@Component({
  selector: 'app-checkoutmodal',
  templateUrl: './checkoutmodal.component.html',
  styleUrls: ['./checkoutmodal.component.css']
})
export class CheckoutmodalComponent implements OnInit {

  @ViewChild('checkoutModal', { static: false }) modal: ModalDirective;
  @ViewChild('scanqrcodeModal', { static: false }) scanqrcodeModal: ScanqrcodemodalComponent;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();
  cartProducts: ShopItems[] = [];
  data: OrderData = new OrderData();
  totalPrice: any = 10 ;

  constructor(private service: CartService) { }

  ngOnInit(): void {
   
  }
  getOrderValues(val) {
   // console.log(val);
  }
  makeOrder(val) {
    console.log(val.name);
    console.log(val.email);
    console.log(val);
    this.data.Name = val.name;
    this.data.Email = val.email;
    //console.log(this.cartProducts);
   // console.log(this.cartProducts[0].id);
    // console.log(this.data);
    console.log(this.data.Products);
    for (let i = 0; i < this.cartProducts.length; i++) {
      console.log("am intrat in for");
      this.data.Products[i] = new OrderProduct(this.cartProducts[i].Id, this.cartProducts[i].Quantity, this.cartProducts[i].Name);
      
    //  this.data.Products[i].Quantity = this.cartProducts[i].quantity;
     // console.log(this.cartProducts[i].id);
      //console.log(this.cartProducts[i].quantity);

    }
   

    console.log(this.data);


    this.service.postCreateOrder(this.data).subscribe((data: any) => { });
  }

  closeModal() {
    this.modal.hide();
  }

  initialize(cart: ShopItems[]): void {
    for (let i = 0; i < cart.length; i++)
      this.cartProducts.push(cart[i]);
    console.log(this.cartProducts);
    for (let j = 0; j < this.cartProducts.length; j++)
      this.totalPrice = this.totalPrice + this.cartProducts[j].Quantity * this.cartProducts[j].Price;
    console.log(this.totalPrice);
    this.modal.show();

  }
  showScanner() {
    this.scanqrcodeModal.initialize();
  }
  applyVoucher(event: string) {
   
      this.totalPrice = this.totalPrice - (25 * this.totalPrice) / 100;
    
   // console.log(this.totalPrice);
    console.log("sunt in apply voucher");
  }

}
