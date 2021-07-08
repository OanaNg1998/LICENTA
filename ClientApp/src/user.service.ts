import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Input } from './app/models/input';
import { Reservation } from './app/models/reservation';
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
  getQRCode(reservation: Reservation) {
    console.log(reservation.ReservationDate);
    
    let param = new HttpParams();
    return this.http.post(this.baseUrl + '/Subscription/Discount',reservation, { headers: this.header,params: param });
  }
  getReservation(reservation: Reservation) {
    console.log(reservation.ReservationDate);

    let param = new HttpParams();
    return this.http.post(this.baseUrl + '/Subscription/Appointment', reservation, { headers: this.header, params: param });
  }
  
  getAllQRCodes() {
    return this.http.get(this.baseUrl + '/SaleQRCode', { headers: this.header });

  }
  
}
