
import { Component } from '@angular/core';
import { User } from '../models/user';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent  {

  public users: User = new User();

  constructor() { }



}
