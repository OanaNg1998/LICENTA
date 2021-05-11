import { ViewChild } from "@angular/core";
import { Component, OnInit } from "@angular/core";
import { Validators } from "@angular/forms";
import { FormGroup } from "@angular/forms";
import { FormBuilder } from "@angular/forms";

import { UserService } from "../../../user.service";
import { User } from "../../models/user";
import { LoaderService } from "../../services/loader.service";
import { FindmeasuremodalComponent } from "./findmeasuremodal/findmeasuremodal.component";



@Component({
  selector: "app-user",
  templateUrl: "user.component.html",
  //styleUrls: ['./loader.component.css']
})
export class UserComponent implements OnInit {

 // public users: User = new User();
 // updateUserForm: FormGroup;
  @ViewChild('findMeasureModal', { static: false }) findMeasureModal: FindmeasuremodalComponent;
  constructor(public fb: FormBuilder, private api: UserService/*, public loaderService: LoaderService*/) { }

  ngOnInit() {

    
   /* this.api['getUser']().subscribe((data: User) => {
      this.users = data;
      this.initializeForm(this.users);
      console.log(this.users);
    })*/
  }

 /* initializeForm(user: User) {
    this.updateUserForm = this.fb.group({
      firstName: [user.FirstName],
      lastName: [user.LastName]

    });
  }

  updateUser() {

    const editedUser = new User(
      this.users.Id,
      this.users.Email,
      this.updateUserForm.value.lastName,
      this.updateUserForm.value.firstName,
      this.users.BirthDate,

    );



    this.api.updateUser(editedUser)
      .subscribe(() => { })

  }*/
  showMeasure() {
    this.findMeasureModal.initialize();
  }


}
