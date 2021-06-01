import { EventEmitter, ViewChild } from '@angular/core';
import { Output } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-findmeasuremodal',
  templateUrl: './findmeasuremodal.component.html',
  styleUrls: ['./findmeasuremodal.component.css']
})
export class FindmeasuremodalComponent implements OnInit {

  @ViewChild('findMeasureModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();
  constructor() { }

  ngOnInit(): void {
  }
  getValues(val) {
    console.log(val);
  }
  initialize( ): void {
  
    this.modal.show();

  }
  findout(val) {
    var generalWMeasure ="xx";
    var jeansWMeasure = "xx";
    var generalMMeasure = "xx";
    var jeansMMeasure = "xx";
    //woman
    if (val.height <= 164 && val.chest <= 78 && val.whaist <= 58 && val.hips <= 84) {
      generalWMeasure = "XXS";
    }
    else if (val.height <= 164 && val.chest > 78 && val.chest <= 82 && val.whaist > 58 && val.whaist <= 62 && val.hips > 84 && val.hips <= 88) {
      generalWMeasure = "XS";
    }
    else if (val.height <= 164 && val.chest > 82 && val.chest <= 86 && val.whaist > 62 && val.whaist <= 66 && val.hips > 88 && val.hips <= 92) {
      generalWMeasure = "S";
    }
    else if (val.height > 164 && val.height <= 170 && val.chest > 86 && val.chest <= 90 && val.whaist > 66 && val.whaist <= 70 && val.hips > 92 && val.hips <= 96) {
      generalWMeasure = "M";
    }
    else if (val.height > 170 && val.height <= 176 && val.chest > 90 && val.chest <= 94 && val.whaist > 70 && val.whaist <= 74 && val.hips > 96 && val.hips <= 100) {
      generalWMeasure = "L";
    }
    else if (val.height > 170 && val.height <= 176 && val.chest > 94 && val.chest <= 98 && val.whaist > 74 && val.whaist <= 78 && val.hips > 100 && val.hips <= 104) {
      generalWMeasure = "XL";
    }
    else if (val.height > 170 && val.height <= 176 && val.chest > 98 && val.chest <= 102 && val.whaist > 78 && val.whaist <= 82 && val.hips > 104 && val.hips <= 108) {
      generalWMeasure = "XXL";
    }
    else if (val.height > 176 || val.chest > 102 || val.whaist > 82 || val.hips > 108) {
      generalWMeasure = "unrecognisable";
    }

    if (val.height <= 164 && val.whaist <= 58 && val.hips <= 84) {
      jeansWMeasure = "32";
    }
    else if (val.height <= 164 && val.whaist > 58 && val.whaist <= 62 && val.hips > 84 && val.hips <= 88) {
      jeansWMeasure = "34";
    }
    else if (val.height <= 164 && val.whaist > 62 && val.whaist <= 66 && val.hips > 88 && val.hips <= 92) {
      jeansWMeasure = "36";
    }
    else if (val.height >164 && val.height <= 170 && val.whaist > 66 && val.whaist <= 70 && val.hips > 92 && val.hips <= 96) {
      jeansWMeasure = "38";
    }
    else if (val.height > 170 && val.height <= 176 && val.whaist > 70 && val.whaist <= 74 && val.hips > 96 && val.hips <= 100) {
      jeansWMeasure = "40";
    }
    else if (val.height > 170 && val.height <= 176 && val.whaist > 74 && val.whaist <= 78 && val.hips > 100 && val.hips <= 104) {
      jeansWMeasure = "42";
    }
    else if (val.height > 176 || val.whaist > 78 || val.hips > 104) {
      jeansWMeasure = "unrecognisable";
    }
    //man
    if (val.height >= 170 && val.height<=174 && val.chest>=86.5 && val.chest<=91.5 && val.whaist>=74.5 && val.whaist<=79.5 && val.hips>=86.5 && val.hips<=91.5) {
      generalMMeasure = "XS";
    }
    else if (val.height >= 174 && val.height <= 176 && val.chest >= 91.5 && val.chest <= 96.5 && val.whaist >= 79.5 && val.whaist <= 84.5 && val.hips >= 91.5 && val.hips <= 96.5){
      generalWMeasure = "S";
    }
    else if (val.height >= 178 && val.height <= 180 && val.chest >= 96.5 && val.chest <= 101.5 && val.whaist >= 84.5 && val.whaist <= 88.5 && val.hips >= 96.5 && val.hips <= 101.5) {
      generalMMeasure = "M";
    }
    else if (val.height >= 180 && val.height <= 184 && val.chest >= 101.5 && val.chest <= 107 && val.whaist >= 89.5 && val.whaist <= 95 && val.hips >= 101.5 && val.hips <= 107) {
      generalWMeasure = "L";
    }
    else if (val.height >= 184 && val.height <= 188 && val.chest >= 107 && val.chest <= 113 && val.whaist >= 95 && val.whaist <= 101 && val.hips >= 107 && val.hips <= 113) {
      generalMMeasure = "XL";
    }
    else if (val.height >= 188 && val.height <= 190 && val.chest >= 113 && val.chest <= 119 && val.whaist >= 101 && val.whaist <= 107 && val.hips >= 113 && val.hips <= 119) {
      generalMMeasure = "XXL";
    }
    else if (val.height > 190 || val.chest > 119 || val.whaist > 107 || val.hips > 119) {
      generalMMeasure = "unrecognisable";
    }

    if (val.height >= 170 && val.height <= 174 && val.whaist >= 74.5 && val.whaist <= 79.5 && val.hips >= 86.5 && val.hips <= 91.5) {
      jeansMMeasure = "28-29";
    }
    else if (val.height >= 174 && val.height <= 176 && val.whaist >= 79.5 && val.whaist <= 84.5 && val.hips >= 91.5 && val.hips <= 96.5) {
      jeansMMeasure = "30-31";
    }
    else if (val.height >= 176 && val.height <= 180 && val.whaist >= 84.5 && val.whaist <= 89.5 && val.hips >= 96.5 && val.hips <= 101.5) {
      jeansMMeasure = "32-33";
    }
    else if (val.height >= 180 && val.height <= 184 && val.whaist >= 89.5 && val.whaist <= 95 && val.hips >= 101.5 && val.hips <= 107) {
      jeansMMeasure = "34";
    }
    else if (val.height >= 184 && val.height <= 188 && val.whaist >= 95 && val.whaist <= 101 && val.hips >= 107 && val.hips <= 113) {
      jeansMMeasure = "36";
    }
    else if (val.height >= 188 && val.height <= 190 && val.whaist >= 101 && val.whaist <= 107 && val.hips >= 113 && val.hips <= 119) {
      jeansMMeasure = "38";
    }
    else if (val.height > 190 ||val.whaist > 107 || val.hips > 119) {
      jeansMMeasure = "unrecognisable";
    }




    if (val.gender == "Female") {

      Swal.fire({
        // title: '25 % OFF VOUCHER',

        html: '<img src="https://i.ibb.co/pv7wrDB/woaman-dress.png" style="margin-left:-15%" />' + '<img src="https://i.ibb.co/v4PPQbm/trousers.png" alt="trousers" style="height:5%;width:35%;margin-left:15%" />' + '<p style="color:black;font-size:75%; display: inline-block;margin-left:-10%;">Your general measure is:  ' + generalWMeasure + '</p>' +
          '<p style="color:black;font-size:75%; display: inline-block;margin-left:27%;">Your jeans measure is:  ' + jeansWMeasure + '</p>',
        // text: 'Your general measure is:' + measure+measure,
        //icon: 'warning',
        showCancelButton: false,
        confirmButtonText: 'Thank you!',
        confirmButtonColor: "#f75986",

      })
    }
    else {
      Swal.fire({
        // title: '25 % OFF VOUCHER',

        html: '<img src="https://i.ibb.co/gT9qZtD/88970578433.png" style="margin-left:-15% ;height:40%;width:50%" />' + '<img src="https://i.ibb.co/v4PPQbm/trousers.png" alt="trousers" style="height:5%;width:35%;margin-left:15%" />' + '<p style="color:black;font-size:70%; display: inline-block;margin-left:-10%;"> Your general measure is:  ' + generalMMeasure + '</p>' +
          '<p style="color:black;font-size:70%; display: inline-block;margin-left:27%;">Your jeans measure is:  ' + jeansMMeasure + '</p>',
        // text: 'Your general measure is:' + measure+measure,
        //icon: 'warning',
        showCancelButton: false,
        confirmButtonText: 'Thank you!',
        confirmButtonColor: "#f75986",

      })
    }
    this.modal.hide();
  }
  

}
