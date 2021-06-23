import { ViewChild } from "@angular/core";
import { Component, OnInit } from "@angular/core";
import { NotificationsService } from "angular2-notifications";
import { CartService } from "../../cart.service";
import { NutritionProduct } from "../../models/nutritionproduct";
import { ProductQuantity } from "../../models/productQuantity";
import { ShopService } from "../../shop.service";
import { NutritionfiltermodalComponent } from "./nutritionfiltermodal/nutritionfiltermodal.component";

@Component({
  selector: "app-icons",
  templateUrl: "icons.component.html",
  styleUrls: ['./icons.component.css']
})
export class IconsComponent implements OnInit {

  public nutritionproducts: any;
 
  nProductQuantities: Array<ProductQuantity> = new Array<ProductQuantity>();
  selectedNOrder: string = '';

  @ViewChild('nutritionfilterModal', { static: false }) nutritionfilterModal: NutritionfiltermodalComponent;
  constructor(private api1: ShopService, private cartService: CartService, private serviceN: NotificationsService) { }

  ngOnInit() {
    this.api1['getNutritionProducts']().subscribe((data: NutritionProduct[]) => {
      this.nutritionproducts = data;
      // console.log(data);
    })
  }
  onNSuccess(message, product: any) {
    this.serviceN.success('Done', message, {
      position: ['top', 'right'],
      timeOut: 2000,
      animate: 'fade',
      showProgressBar: true,


    });

    //console.log(product.id);
    product.quantity = this.getNProductQuantity(product.id);
    console.log(this.getNProductQuantity(product.id));
    this.cartService.add(product);
    // console.log("am adaugat");
  }
  selectChangeHandler(event: any) {
    this.selectedNOrder = event.target.value;
    if (this.selectedNOrder == "desc") {
      this.api1['orderNPDescByPrice']().subscribe((data: NutritionProduct[]) => {
        this.nutritionproducts = data;

        // console.log(data);
      });
    }

    else if (this.selectedNOrder == "cresc") {
      this.api1['orderNPCrescByPrice']().subscribe((data: NutritionProduct[]) => {
        this.nutritionproducts = data;
        // console.log(data);
      });

    }
    //  console.log(this.selectedOrder);
  }
  getNProductQuantity(productId: string) {
    for (let i = 0; i < this.nProductQuantities.length; i++) {
      if (this.nProductQuantities[i].productId == productId) {
        return this.nProductQuantities[i].quantity;
      }
    }
    return 0;
  }

  inc(productId: string) {
    var found = new Boolean(false);
    for (let i = 0; i < this.nProductQuantities.length; i++) {
      if (this.nProductQuantities[i].productId == productId) {
        this.nProductQuantities[i].quantity += 1;
        found = true;
      }
    }

    if (found == false) {
      var newProduct = new ProductQuantity(productId, 1);
      this.nProductQuantities.push(newProduct);
    }

   

  }

  dec(productId: string) {
    var found = new Boolean(false);
    for (let i = 0; i < this.nProductQuantities.length; i++) {
      if (this.nProductQuantities[i].productId == productId && this.nProductQuantities[i].quantity != 0) {
        this.nProductQuantities[i].quantity -= 1;
        found = true;
      }
    }

    if (found == false) {
      var newProduct = new ProductQuantity(productId, 0);
      this.nProductQuantities.push(newProduct);
    }
  }
  showNutritionFilter() {
    this.nutritionfilterModal.initialize();
   

  }

}
