import { EventEmitter, ViewChild } from '@angular/core';
import { Output } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import Swal from 'sweetalert2';
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
  totalPrice: any = 0;
  totalOTPrice: any = 0;
  sale: any = false;

  constructor(private service: CartService) { }

  ngOnInit(): void {
   
  }
  getOrderValues(val) {
    console.log(val);
  }
  makeOrder(val) {
    var validName = 0;
    var validEmail = 0;
    var validPhonenumber = 0;
    var validCity = 0;
    var validCounty = 0;
    var validDeliveryAddress = 0;
    if (!/[^a-zA-Z\s]/.test(val.name) == true && val.name!="") validName = 1;
    if (val.email.includes("@") == true&& val.email!="") validEmail = 1;
    if (/^\d+$/.test(val.phonenumber)) validPhonenumber = 1;
    if (!/[^a-zA-Z\s]/.test(val.city) == true && val.city!="") validCity = 1;
    if (!/[^a-zA-Z\s]/.test(val.county) == true && val.county!="") validCounty = 1;
    if (/^(\w|\.|\s)+$/.test(val.deliveryaddress) == true && val.deliveryaddress!="") validDeliveryAddress = 1;
    
    console.log("adresa nume " + validName);
    console.log("email valid " + validEmail);
    console.log("nr de tel " + validPhonenumber);
    console.log(" oras valid " + validCity);
    console.log(" judet valid " + validCounty);
    console.log("adresa livrare valida " + validDeliveryAddress);
    
    if (validName == 0 || validEmail == 0 || validPhonenumber == 0 || validCity == 0 || validCounty == 0 ||validDeliveryAddress == 0 ) {
      Swal.fire({
        icon: 'error',
        title: 'Invalid input',
        text: 'Verify that your inputs are not empty and also that are correctly introduced.(Email needs to contain character @ ,name,city,county must contain only letters,phonenumber must contain only numbers)',
        confirmButtonColor: 'red',
        width: '30vw',
      })
    } else {


      this.data.Name = val.name;
      this.data.Email = val.email;
      this.data.DeliveryAddress = val.deliveryaddress + "," + val.city + "," + val.county;
      this.data.PhoneNumber = val.phonenumber;
      console.log("a intrat in apply voucher" + this.sale);
      if (this.sale == false) this.data.AppliedVoucher = false;
      else this.data.AppliedVoucher = true;

      // console.log(this.data.DeliveryAddress);

      //console.log(this.cartProducts);
      // console.log(this.cartProducts[0].id);
      // console.log(this.data);
      // console.log(this.data.Products);
      for (let i = 0; i < this.cartProducts.length; i++) {
        // console.log("am intrat in for");
        this.data.Products[i] = new OrderProduct(this.cartProducts[i].Id, this.cartProducts[i].Quantity, this.cartProducts[i].Name, this.cartProducts[i].Price, this.cartProducts[i].Image, this.cartProducts[i].Measure);


      }

      this.service.postCreateOrder(this.data).subscribe((data: any) => { });
      this.change.emit('golit');
      Swal.fire({
        title: 'Thank you !',
        text: 'Your order has been registered successfully, you will receive an email with the order details.',
        icon: 'success',
        showCancelButton: false,
        confirmButtonText: 'Ok,got it!',
        confirmButtonColor: "#f75986",

      })
      this.modal.hide();
    }
  }

  closeModal() {
    this.modal.hide();
  }

  initialize(cart: ShopItems[]): void {
    for (let i = 0; i < cart.length; i++)
      this.cartProducts.push(cart[i]);
   // console.log(this.cartProducts);
    for (let j = 0; j < this.cartProducts.length; j++)
      this.totalPrice = this.totalPrice + this.cartProducts[j].Quantity * this.cartProducts[j].Price;
    
   // console.log(this.totalPrice);
    this.modal.show();

  }
  showScanner() {
    this.scanqrcodeModal.initialize();
  }
  applyVoucher(event: string) {
    this.sale = true;
    this.totalPrice = (this.totalPrice - (25 * this.totalPrice) / 100);
    
   // console.log(this.applySale);
  
    
   // console.log(this.totalPrice);
    console.log("sunt in apply voucher");
  }

}
