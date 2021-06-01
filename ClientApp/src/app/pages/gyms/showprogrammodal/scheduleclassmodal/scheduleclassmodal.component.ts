import { Component, ElementRef, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import Swal from 'sweetalert2';
import { UserService } from '../../../../../user.service';


@Component({
  selector: 'app-scheduleclassmodal',
  templateUrl: './scheduleclassmodal.component.html',
  styleUrls: ['./scheduleclassmodal.component.css']
})
export class ScheduleclassmodalComponent implements OnInit {
  @ViewChild('scheduleClassModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();
  public title: any;
  image: any;
  

  constructor(private api2: UserService) { }

  ngOnInit(): void {
  }
  initialize(className): void {
    console.log(className);
    this.title = className;
    
    this.modal.show();

  }
  getValues(val) {
    console.log(val);
  }
  sale(val) {
    
    if (val.numberFriends > 2) {
     
      Swal.fire({
        title: '25 % OFF VOUCHER',
        text: 'We have sent you an email with your sale code',
        icon: 'warning',
        showCancelButton: false,
        confirmButtonText: 'Ok,got it !',
        confirmButtonColor: "#f75986",

      })
      this.api2['getQRCode'](val.emailAddress).subscribe((data: any) => {
        this.image = data;
        console.log(this.image);

      })


     
    }
    else {
      Swal.fire({
        title: '25 % OFF VOUCHER',
        text: 'Your Subscription has been sent!',
        icon: 'warning',
        showCancelButton: false,
        confirmButtonText: 'Ok,got it !',
        confirmButtonColor: "#f75986",

      })

    }
    this.modal.hide();
  }
  


}
