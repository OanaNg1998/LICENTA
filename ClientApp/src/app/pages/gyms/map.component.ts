import { Component, OnInit, ViewChild } from "@angular/core";
import { GymService } from "../../../gym.service";
import { UserService } from "../../../user.service";
import { HomeComponent } from "../../home/home.component";

import { Gym } from "../../models/gym";
import { ShowprogrammodalComponent } from "./showprogrammodal/showprogrammodal.component";





@Component({
  selector: "app-map",
  templateUrl: "map.component.html"
})
export class MapComponent implements OnInit {
  public gyms: Array<Gym> = new Array<Gym>();
  public gymCity: any;

  @ViewChild('showProgramModal', { static: false }) showProgramModal: ShowprogrammodalComponent;

  constructor(private api1: GymService,  private homeComponent: HomeComponent) { }

  ngOnInit() {
    this.gymCity = this.homeComponent.getSelectedAddress();
    console.log("HOME COMPONENT");
    console.log(this.gymCity);

    this.api1['getGymsFromCity'](this.gymCity).subscribe((data: Gym[]) => {
      this.gyms = data;
      console.log(data);
    })
  

  }

  

  showProgram(gymId: string) {
    this.showProgramModal.initialize(gymId);
  }

}
