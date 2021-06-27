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

  public nutritionProducts: any;
 
  nProductQuantities: Array<ProductQuantity> = new Array<ProductQuantity>();
  selectedNOrder: string = '';
  isfilteredNProducts: number = 0;
  public filteredNProducts: Array<NutritionProduct> = new Array<NutritionProduct>();

  @ViewChild('nutritionfilterModal', { static: false }) nutritionfilterModal: NutritionfiltermodalComponent;
  constructor(private api1: ShopService, private cartService: CartService, private serviceN: NotificationsService) { }

  ngOnInit() {
    this.api1['getNutritionProducts']().subscribe((data: NutritionProduct[]) => {
      this.nutritionProducts = data;
      console.log("in ng "+this.nutritionProducts);
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
  filterNProduct(event: string) {
    console.log("a intrat in icons " + this.nutritionfilterModal.isNFilter);
    if (this.nutritionfilterModal.isNFilter == 1) {
      this.isfilteredNProducts = 1;
    }
    if (this.isfilteredNProducts == 1) {
      // console.log("categorie:"+this.filterModal.filterValue.Category);
      // console.log("gen" + this.filterModal.filterValue.Gender);
      // console.log(this.filterModal.filterValue);
      while (this.filteredNProducts.length > 0) {
        this.filteredNProducts.pop();
      }

      console.log("categorie in icons " + this.nutritionfilterModal.filterNValue.Brand);
      for (let k = 0; k < this.nutritionProducts.length; k++) {


        console.log("produse " + this.nutritionProducts[k].Category);
        console.log("produse " + this.nutritionProducts[k].Brand);
        console.log("produse " + this.nutritionProducts[k].Price);


      }
      console.log("brand filtrat "+this.nutritionfilterModal.filterNValue.Brand);
      for (let i = 0; i < this.nutritionProducts.length; i++) {
        console.log("categorii baza de date " + this.nutritionProducts[i].price);
        if (this.nutritionProducts[i].category == this.nutritionfilterModal.filterNValue.Category && this.nutritionProducts[i].brand == this.nutritionfilterModal.filterNValue.Brand  && this.nutritionProducts[i].price >= this.nutritionfilterModal.filterNValue.Price[0] && this.nutritionProducts[i].price <= this.nutritionfilterModal.filterNValue.Price[1]) {
          this.filteredNProducts.push(this.nutritionProducts[i]);
        }
      }
    }


  }
  selectChangeHandler(event: any) {
    this.selectedNOrder = event.target.value;
    if (this.selectedNOrder == "desc") {
      this.api1['orderNPDescByPrice']().subscribe((data: NutritionProduct[]) => {
        this.nutritionProducts = data;

        // console.log(data);
      });
    }

    else if (this.selectedNOrder == "cresc") {
      this.api1['orderNPCrescByPrice']().subscribe((data: NutritionProduct[]) => {
        this.nutritionProducts = data;
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
