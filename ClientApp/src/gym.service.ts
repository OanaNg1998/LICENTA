import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient, HttpParams } from '@angular/common/http';
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
  getGymsFromCity(city:string)//val: string) {
  // let param = new HttpParams().set('city', val);
  {
    //console.log(city);
    //console.log(city);
    let param = new HttpParams().set('city', city);
    return this.http.get(this.baseUrl + '/Gym',  { headers: this.header, params: param });
  }
  getGymById(gymId: string) {
    console.log(gymId);
    return this.http.get(this.baseUrl + '/GymTraining/' + gymId, { headers: this.header });

  }
 


}


