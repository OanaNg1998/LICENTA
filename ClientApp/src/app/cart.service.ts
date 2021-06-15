import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Equipment } from './models/equipment';
import { OrderData } from './models/orderData';
import { UserComponent } from './pages/user/user.component';

@Injectable({
  providedIn: 'root'
})
export class CartService {

  cartProducts: Equipment[] = [];

  constructor(private http: HttpClient) {
  }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44315/api';
  add(product: Equipment) {
   
    this.cartProducts.push(product);
  }
  get() {
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
