import { ViewChild } from '@angular/core';
import { Output } from '@angular/core';
import { EventEmitter } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { Options } from 'ng5-slider';
import { ModalDirective } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-nutritionfiltermodal',
  templateUrl: './nutritionfiltermodal.component.html',
  styleUrls: ['./nutritionfiltermodal.component.css']
})
export class NutritionfiltermodalComponent implements OnInit {

  @ViewChild('nutritionfilterModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();
  constructor() { }

  ngOnInit(): void {
  }
  value: number = 40;
  highValue: number = 60;
  options: Options = {
    floor: 0,
    ceil: 100
  };
  initialize(): void {

    this.modal.show();

  }

}
