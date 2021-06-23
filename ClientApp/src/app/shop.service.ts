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
  getNutritionProducts() {
    return this.http.get(this.baseUrl + '/NutritionProduct', { headers: this.header });
  }
  orderDescByPrice() {
    return this.http.get(this.baseUrl + '/Equipment/OrderDescByPrice', { headers: this.header });
  }
  orderCrescByPrice() {
    return this.http.get(this.baseUrl + '/Equipment/OrderCrescByPrice', { headers: this.header });
  }
  orderNPDescByPrice() {
    return this.http.get(this.baseUrl + '/NutritionProduct/OrderNPDescByPrice', { headers: this.header });
  }
  orderNPCrescByPrice() {
    return this.http.get(this.baseUrl + '/NutritionProduct/OrderNPCrescByPrice', { headers: this.header });
  }
  getBrandsForSearchbarFilter() {
    return this.http.get(this.baseUrl + '/Equipment/GetBrands', { headers: this.header });
  }

}
