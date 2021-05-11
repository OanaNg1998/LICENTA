import { Component, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { GymService } from '../../../../gym.service';
import { UserService } from '../../../../user.service';
import { Gym } from '../../../models/gym';
import { Training } from '../../../models/training';
import { ScheduleclassmodalComponent } from "./scheduleclassmodal/scheduleclassmodal.component";
import Swal from 'sweetalert2';



@Component({
  selector: 'app-showprogrammodal',
  templateUrl: './showprogrammodal.component.html',
  styleUrls: ['./showprogrammodal.component.css']
})
export class ShowprogrammodalComponent implements OnInit {

  @ViewChild('showProgramModal', { static: false }) modal: ModalDirective;
  @ViewChild('scheduleClassModal', { static: false }) scheduleClassModal: ScheduleclassmodalComponent;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();
  trainings: Array<Training> = [];
 // image:any;
  
  
  //image: HTMLImageElement;
  //qrCodeString: string;

 

  constructor(private gymService: GymService, private api2: UserService,) { }

  ngOnInit(): void {
   // this.qrCodeString = this.randomString(100, '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ');
   /* this.api2['getQRCode']().subscribe((data:any) => {
      this.image = data;
      console.log(this.image);
      
    })*/
   
    

  }
  randomString(length, chars) {
  var result = '';
  for (var i = length; i > 0; --i) result += chars[Math.floor(Math.random() * chars.length)];
  return result;
  }

  initialize(gymId: string): void {
    console.log(gymId);

    this.gymService.getGymById(gymId).subscribe((result: Array<Training>) => {
      this.trainings = result;
      
      console.log(this.trainings);
    })
    this.modal.show();
   
  }
  showFormular(className:string) {
    this.scheduleClassModal.initialize(className);
    Swal.fire({
      title: '25 % OFF VOUCHER',
      text: 'Bring more than two friends and the voucher will be yours !!!',
      icon: 'warning',
      showCancelButton: false,
      confirmButtonText: 'Ok,got it !',
      confirmButtonColor: "#f75986",
      
    })/*.then((result) => {
      if (result.value) {
        Swal.fire(
          'Deleted!',
          'Your imaginary file has been deleted.',
          'success'
        )
        // For more information about handling dismissals please visit
        // https://sweetalert2.github.io/#handling-dismissals
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        Swal.fire(
          'Cancelled',
          'Your imaginary file is safe :)',
          'error'
        )
      }
    })*/

  }
  
  /*createSubscription(gymId: string) {

    console.log(gymId);
    this.api2.postUserSubscription(gymId).subscribe((data: any) => {
    });
    


  }*/

}
