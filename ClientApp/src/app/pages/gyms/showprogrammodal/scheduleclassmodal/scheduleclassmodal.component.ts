import { Component, ElementRef, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import Swal from 'sweetalert2';
import { UserService } from '../../../../../user.service';
import { Reservation } from '../../../../models/reservation';


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
  today: Date = new Date();
  todayDate: any;
  classDay: any;
  reservation: any;
  dayValue: any;
  

  constructor(private api2: UserService) { }

  ngOnInit(): void {
    this.todayDate = this.today.toISOString().slice(0, 10);
  }
  initialize(className,day): void {
   // console.log(className);
    this.title = className;
    this.classDay = day;
   // console.log(this.dayClass);
    
    this.modal.show();

  }
  getValues(val) {
    console.log(val);
  }
  closeModal() {
    this.modal.hide();  }
  sale(val) {
    var reservationdate = new Date(val.reservationDate);
    //validare campuri
    var validOwN = 0;
    var validEmail = 0;
    var validDate = 0;
    var validNrF = 0;
    //if (val.ownerName.required == false) console.log("este 000000000");

    if (!/[^a-zA-Z\s]/.test(val.ownerName) == true && val.ownerName!="") validOwN = 1;
    if (val.emailAddress.includes("@") == true && val.emailAddress!="") validEmail = 1;
    if (reservationdate >= this.today && val.reservationDate!="") validDate = 1;
    if (val.numberFriends > 0 && val.numberFriends!="" ) {
      // console.log("am intrat in claid friends");
      validNrF = 1;
    }
    console.log(validOwN);
    console.log(validEmail);
    console.log(validDate);
    console.log(validNrF);

    if (this.classDay == "Monday") this.dayValue = 1;
    if (this.classDay == "Tuesday") this.dayValue = 2;
    if (this.classDay == "Wednesday") this.dayValue = 3;
    if (this.classDay == "Thursday") this.dayValue = 4;
    if (this.classDay == "Friday") this.dayValue = 5;
    if (this.classDay == "Saturday") this.dayValue = 6;

   
    this.reservation = new Reservation(reservationdate, val.emailAddress, val.ownerName, this.title, val.numberFriends);
    // console.log(this.reservation);
    if (validOwN == 0 || validEmail == 0 || validDate == 0 || validNrF == 0) {
      Swal.fire({
        icon: 'error',
        title: 'Invalid input',
        text: 'Verify that your inputs are not empty and also that are correctly introduced.(Email needs to contain character @ ,name needs to contain only letters,the date needs to be valid)',
        confirmButtonColor: 'red',
        width: '30vw',
      })
    }
    else {
    
      if (reservationdate.getDay() != this.dayValue) {
        Swal.fire({
          icon: 'error',
          title: 'Invalid day',
          text: 'You must make an appointment on the specified day of week',
          confirmButtonColor: 'red',
          width: '30vw',
        })
        //console.log("trebuie sa alegem o alta zi !!!");
      }
      else {
        this.api2['getReservation'](this.reservation).subscribe((data: any) => {

        })

        if (val.numberFriends > 2) {

          Swal.fire({
            title: '25 % OFF VOUCHER',
            text: 'We have sent you an email with your sale code',
            icon: 'warning',
            showCancelButton: false,
            confirmButtonText: 'Ok,got it !',
            confirmButtonColor: "#f75986",

          })
          this.api2['getQRCode'](this.reservation).subscribe((data: any) => {
            this.image = data;
            console.log(this.image);

          })



        }
        else {
          Swal.fire({
            title: 'THANK YOU!',
            text: 'Your Subscription has been sent, we have sent you an email with the details!',
            icon: 'warning',
            showCancelButton: false,
            confirmButtonText: 'Ok,got it !',
            confirmButtonColor: "#f75986",

          })

        }
        this.modal.hide();
      }
    }
  }
  


}
