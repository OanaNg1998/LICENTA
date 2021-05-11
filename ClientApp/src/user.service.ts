import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Input } from './app/models/input';
import { User } from './app/models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) {
  }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44315/api';
  adresa: Input;
  getUser() {
    return this.http.get(this.baseUrl + '/User', { headers: this.header });
  }
  postUserSubscription(GymId: string) {
    return this.http.post(this.baseUrl + '/UserSubscription', GymId, { headers: this.header });
  }
  updateUser(user: User) {
    return this.http.put(this.baseUrl + '/User', user, { headers: this.header });
  }
  getQRCode(emailAddress: string) {
    console.log("EMAIL IS: ");
    console.log(emailAddress);
    //this.adresa = new Input(emailAddress);
    
    let param = new HttpParams().set('emailAddress', emailAddress);
    return this.http.get(this.baseUrl + '/Subscription/Discount', { headers: this.header,params: param });
  }
  
}
