import { ViewChild } from "@angular/core";
import { Component, OnInit } from "@angular/core";
import { ToastrService } from 'ngx-toastr';
import Swal from "sweetalert2";
import { CartService } from "../../cart.service";
import { Equipment } from "../../models/equipment";
import { ShopItems } from "../../models/shopItems";
import { ShopService } from "../../shop.service";
import { UserComponent } from "../user/user.component";
import { CheckoutmodalComponent } from "./checkoutmodal/checkoutmodal.component";

@Component({
  selector: "app-notifications",
  templateUrl: "notifications.component.html",
    styleUrls: ['./notifications.component.css']
})
export class NotificationsComponent implements OnInit {

  cartContent: ShopItems[] = [];
  public static totalItems: any = 0;
  
  @ViewChild('checkoutModal', { static: false }) checkoutModal: CheckoutmodalComponent;
  constructor(private cartService: CartService) { }

  ngOnInit() {
    console.log(this.cartService.get());
    for (let i = 0; i < this.cartService.get().length; i++)
      this.cartContent.push(this.cartService.get()[i]);
    console.log(this.cartContent);
    for (let j = 0; j < this.cartContent.length; j++)
      // console.log(this.cartContent[j].Quantity);
      NotificationsComponent.totalItems = NotificationsComponent.totalItems + this.cartContent[j].Quantity;
    console.log(NotificationsComponent.totalItems);
    
   // this.cartContent = this.cartService.get();
    //console.log("am adaugat urm produse:"+this.cartContent);
    console.log(this.getTotalItems());

  }
  delete(index: number) {
    this.cartContent.splice(index, 1);

    /*for (let j = 0; j < this.cartService.get().length; j++) {
      if (this.cartService.get()[j].Id == Id) delete this.cartService.get()[j];
    }
    console.log(this.cartService.get());*/
   // console.log(this.cartContent);
  }
  public getTotalItems() {
    return NotificationsComponent.totalItems;
  }
  emptyShoppingCart(event: string) {
    while (this.cartContent.length > 0) {
      this.cartContent.pop();
    }
    while (this.cartService.get().length > 0) {
      this.cartService.get().pop();
    }

   

  }


  showFinalOrder() {
    this.checkoutModal.initialize(this.cartContent);
   /* for (let j = 0; j > this.cartContent.length; j++)
      NotificationsComponent.totalItems = NotificationsComponent.totalItems + this.cartContent[j].Quantity;
    console.log(NotificationsComponent.totalItems);*/
  }
 

}
   

/*export class NotificationsComponent implements OnInit {
  staticAlertClosed  = false;
  staticAlertClosed1 = false;
  staticAlertClosed2 = false;
  staticAlertClosed3 = false;
  staticAlertClosed4 = false;
  staticAlertClosed5 = false;
  staticAlertClosed6 = false;
  staticAlertClosed7 = false;

  constructor(private toastr: ToastrService) {}
  
  showNotification(from, align){

      const color = Math.floor((Math.random() * 5) + 1);

      switch(color){
        case 1:
        this.toastr.info('<span class="tim-icons icon-bell-55" [data-notify]="icon"></span> Welcome to <b>Black Dashboard Angular</b> - a beautiful freebie for every web developer.', '', {
           disableTimeOut: true,
           closeButton: true,
           enableHtml: true,
           toastClass: "alert alert-info alert-with-icon",
           positionClass: 'toast-' + from + '-' +  align
         });
        break;
        case 2:
        this.toastr.success('<span class="tim-icons icon-bell-55" [data-notify]="icon"></span> Welcome to <b>Black Dashboard Angular</b> - a beautiful freebie for every web developer.', '', {
           disableTimeOut: true,
           closeButton: true,
           enableHtml: true,
           toastClass: "alert alert-success alert-with-icon",
           positionClass: 'toast-' + from + '-' +  align
         });
        break;
        case 3:
        this.toastr.warning('<span class="tim-icons icon-bell-55" [data-notify]="icon"></span> Welcome to <b>Black Dashboard Angular</b> - a beautiful freebie for every web developer.', '', {
           disableTimeOut: true,
           closeButton: true,
           enableHtml: true,
           toastClass: "alert alert-warning alert-with-icon",
           positionClass: 'toast-' + from + '-' +  align
         });
        break;
        case 4:
        this.toastr.error('<span class="tim-icons icon-bell-55" [data-notify]="icon"></span> Welcome to <b>Black Dashboard Angular</b> - a beautiful freebie for every web developer.', '', {
           disableTimeOut: true,
           enableHtml: true,
           closeButton: true,
           toastClass: "alert alert-danger alert-with-icon",
           positionClass: 'toast-' + from + '-' +  align
         });
         break;
         case 5:
         this.toastr.show('<span class="tim-icons icon-bell-55" [data-notify]="icon"></span> Welcome to <b>Black Dashboard Angular</b> - a beautiful freebie for every web developer.', '', {
            disableTimeOut: true,
            closeButton: true,
            enableHtml: true,
            toastClass: "alert alert-primary alert-with-icon",
            positionClass: 'toast-' + from + '-' +  align
          });
        break;
        default:
        break;
      }
  }

  ngOnInit() {}
}*/
