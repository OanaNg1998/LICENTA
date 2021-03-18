
import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { AddressService } from '../../address.service';
import { GymService } from '../../gym.service';
import { Address } from '../models/address';
import { User } from '../models/user';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent  {

  public users: User = new User();
  public static selected: any;
  public addresses: Array<Address> = new Array<Address>();
  keyword = 'city';
  data = [
    {
      id: 1,
      name: 'Usa'
    },
    {
      id: 2,
      name: 'England'
    }
  ];
  public data$: Observable<any[]>;
  constructor(private api: AddressService, private api2: GymService) {

  }

  public getSelectedAddress() {
    return HomeComponent.selected;
  }

  selectEvent(item) {

    HomeComponent.selected = item.city;

  }

  ngOnInit() {
    this.api['getAddresses']().subscribe((data: Address[]) => {
      this.addresses = data;
      console.log(data);


    })

   
  }



}
