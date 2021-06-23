import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Equipment } from './models/equipment';
import { OrderData } from './models/orderData';
import { ShopItems } from './models/shopItems';
import { UserComponent } from './pages/user/user.component';

@Injectable({
  providedIn: 'root'
})
export class CartService {

   cartProducts: ShopItems[] = [];
  //addedProduct: ShopItems;
  //addedProduct: ShopItems;

  constructor(private http: HttpClient) {
  }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44315/api';
  add(product: any) {
    var addedProduct: ShopItems;
   
    addedProduct = new ShopItems(product.id, product.productName, product.quantity, product.price, product.image,product.measure);
    // this.cartProducts.push(product);
    console.log(addedProduct.Measure);
    console.log(addedProduct);
    this.cartProducts.push(addedProduct);
   // console.log(this.cartProducts);
  }
  get() {
    console.log("GET" + this.cartProducts);
    return this.cartProducts;
  }
  updateProduct(product: Equipment) {
    return this.http.put(this.baseUrl + '/Equipment', product, { headers: this.header });
  }
  postCreateOrder(data: OrderData) {
    //console.log(name);
   // console.log(email);
    let params= new HttpParams();
    //params = params.append('name', name);
   // params = params.append('email', email);

   // let param2 = new HttpParams().set('emailAddress', email);
    return this.http.post(this.baseUrl + '/OrderHistory',data,{ headers: this.header,params: params });
  }
  
}
