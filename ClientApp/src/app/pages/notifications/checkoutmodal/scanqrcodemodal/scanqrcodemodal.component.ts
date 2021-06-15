import { EventEmitter, ViewChild } from '@angular/core';
import { Output } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';



@Component({
  selector: 'app-scanqrcodemodal',
  templateUrl: './scanqrcodemodal.component.html',
  styleUrls: ['./scanqrcodemodal.component.css']
})
export class ScanqrcodemodalComponent implements OnInit {
  @ViewChild('scanqrcodeModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();

  constructor() { }

  ngOnInit(): void {
  }

  initialize(): void {
    
    this.modal.show();

  }

}
