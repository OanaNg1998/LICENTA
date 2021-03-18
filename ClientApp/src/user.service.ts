import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from './app/models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44315/api';
  getUser() {
    return this.http.get(this.baseUrl + '/User', { headers: this.header });
  }
  postUserSubscription(GymId: string) {
    return this.http.post(this.baseUrl + '/UserSubscription', GymId, { headers: this.header });
  }
  updateUser(user: User) {
    return this.http.put(this.baseUrl + '/User', user, { headers: this.header });
  }
  
}
