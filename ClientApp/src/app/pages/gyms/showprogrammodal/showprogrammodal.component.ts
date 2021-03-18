import { Component, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { GymService } from '../../../../gym.service';
import { UserService } from '../../../../user.service';
import { Gym } from '../../../models/gym';
import { Training } from '../../../models/training';

@Component({
  selector: 'app-showprogrammodal',
  templateUrl: './showprogrammodal.component.html',
  styleUrls: ['./showprogrammodal.component.css']
})
export class ShowprogrammodalComponent implements OnInit {

  @ViewChild('showProgramModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();
  trainings: Array<Training> = [];

  constructor(private gymService: GymService, private api2: UserService,) { }

  ngOnInit(): void {
  }

  initialize(gymId: string): void {
    console.log(gymId);

    this.gymService.getGymById(gymId).subscribe((result: Array<Training>) => {
      this.trainings = result;
      console.log(this.trainings);
    })
    this.modal.show();
   
  }
  /*createSubscription(gymId: string) {

    console.log(gymId);
    this.api2.postUserSubscription(gymId).subscribe((data: any) => {
    });
    


  }*/

}
