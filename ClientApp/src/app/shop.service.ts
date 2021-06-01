import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ShopService {

  constructor(private http: HttpClient) {
  }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44315/api';

  
  getProducts() {
    return this.http.get(this.baseUrl + '/Equipment', { headers: this.header });
  }
  orderDescByPrice() {
    return this.http.get(this.baseUrl + '/Equipment/OrderDescByPrice', { headers: this.header });
  }
  orderCrescByPrice() {
    return this.http.get(this.baseUrl + '/Equipment/OrderCrescByPrice', { headers: this.header });
  }

}
