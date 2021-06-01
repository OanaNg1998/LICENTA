import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Equipment } from './models/equipment';
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
  
}
