import { EventEmitter, ViewChild } from '@angular/core';
import { Output } from '@angular/core';
import { ChangeDetectorRef } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import Swal from 'sweetalert2';
import { UserService } from '../../../../../user.service';
import { SaleQRCode } from '../../../../models/SaleQRCode';



@Component({
  selector: 'app-scanqrcodemodal',
  templateUrl: './scanqrcodemodal.component.html',
  styleUrls: ['./scanqrcodemodal.component.css']
})
export class ScanqrcodemodalComponent implements OnInit {

  public scannerEnabled: boolean = true;
  public valid: boolean = false ;
 // public scan_qrCode: boolean = false;
  private information: string = "Niciun cod QR detectat. Apropie un cod pentru a-l scana.";
  private qrCode: string;
  public codes: Array<any> = [];
  @ViewChild('scanqrcodeModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();

  constructor(private api: UserService, private cd: ChangeDetectorRef) { }

  ngOnInit(): void {
  }
  initialize(): void {

    this.modal.show();

  }
  closeModal() {
    this.modal.hide();
  }
  public scanSuccessHandler($event: any) {
    this.scannerEnabled = false;
    this.information = "Se extrage informația.. ";

    console.log(String($event));
    this.validateQrCode(String($event));
    console.log("rhbihgifhgihighfi");
    console.log(this.valid);
   
    /*
    if (this.validateQrCode(String($event))) {

      this.qrCode = String($event);
      console.log("sunt aici");
      
    }
    else {
      Swal.fire({
        icon: 'error',
        title: 'Cod QR invalid',
        text: 'Codul pe care ai încercat să îl scanezi nu este valid',
        confirmButtonColor: 'red',
        width: '30vw',
      })
    }
    */
    this.cd.markForCheck();
    this.modal.hide();
  }
  public enableScanner() {
    this.scannerEnabled = !this.scannerEnabled;
    this.information = "Niciun cod QR detectat. Apropie un cod pentru a-l scana.";
  }
  public validateQrCode(qrCode: string) {
    
    this.api['getAllQRCodes']().subscribe((data: any) => {
      this.codes = data;
      console.log(this.codes);

      for (var i = 0; i < this.codes.length; i++) {
        console.log("ORICE");
        if (this.codes[i].qrText == qrCode) { this.valid = true;
        this.change.emit('scanat');
      }
       // console.log("vector" + this.codes[i].QRText);
      }
      console.log(this.valid);
      if (this.valid == false) {
        Swal.fire({
          icon: 'error',
          title: 'Cod QR invalid',
          text: 'Codul pe care ai încercat să îl scanezi nu este valid',
          confirmButtonColor: 'red',
          width: '30vw',
        })
      }
      
    })
   // console.log("sunt in for");
    //return this.valid;
  
    
   
   
   /* let isNum = /^\d+$/.test(qrCode);
    return (qrCode.length === 8 && isNum === true && ['1', '2', '3'].includes(qrCode.charAt(0)));*/

  }

 

}
