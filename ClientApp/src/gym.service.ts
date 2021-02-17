import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class GymService {

  constructor(private http: HttpClient) { }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44315/api';
  getGymsFromCity() {
    return this.http.get(this.baseUrl + '/Gym', { headers: this.header });
  }
 


}


