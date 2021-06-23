import { ViewChild } from "@angular/core";
import { Component, OnInit } from "@angular/core";
import { Validators } from "@angular/forms";
import { FormGroup } from "@angular/forms";
import { FormBuilder } from "@angular/forms";

import { UserService } from "../../../user.service";
import { Equipment } from "../../models/equipment";
import { User } from "../../models/user";
import { LoaderService } from "../../services/loader.service";
import { ShopService } from "../../shop.service";
import { FindmeasuremodalComponent } from "./findmeasuremodal/findmeasuremodal.component";
import { NotificationsService } from 'angular2-notifications';
import { CartService } from "../../cart.service";
import { ProductQuantity } from "../../models/productQuantity";
import { NavbarComponent } from "../../components/navbar/navbar.component";
import { FiltermodalComponent } from "./filtermodal/filtermodal.component";


@Component({
  selector: "app-user",
  templateUrl: "user.component.html",
  styleUrls: ['./user.component.css']
  //styleUrls: ['./loader.component.css']
})


export class UserComponent implements OnInit {

 // public users: User = new User();
 // updateUserForm: FormGroup;
  
  qty: number = 0;
  measure: string;
  productQuantities: Array<ProductQuantity> = new Array<ProductQuantity>();
  selectedOrder: string = '';
  aux: Equipment = new Equipment();
  isfilteredProducts: number = 0;
  public products: any;/* Array<Equipment> = new Array<Equipment>();*/
  public filteredProducts: Array<Equipment> = new Array<Equipment>();
  @ViewChild('findMeasureModal', { static: false }) findMeasureModal: FindmeasuremodalComponent;
  @ViewChild('filterModal', { static: false }) filterModal: FiltermodalComponent;
  constructor(public fb: FormBuilder, private api: UserService, private api1: ShopService, private service: NotificationsService, private cartService: CartService/*, public loaderService: LoaderService*/) { }

  ngOnInit() {
    this.api1['getProducts']().subscribe((data: Equipment[]) => {
      this.products = data;
      // console.log(data);
    })
    
   /* this.api['getUser']().subscribe((data: User) => {
      this.users = data;
      this.initializeForm(this.users);
      console.log(this.users);
    })*/
  }
  filterProduct(event: string) {
   
   if (this.filterModal.isFilter == 1) {
    this.isfilteredProducts = 1;
  }
    if (this.isfilteredProducts == 1) {
     // console.log("categorie:"+this.filterModal.filterValue.Category);
      // console.log("gen" + this.filterModal.filterValue.Gender);
     // console.log(this.filterModal.filterValue);
      while (this.filteredProducts.length > 0) {
        this.filteredProducts.pop();
      }
     

      for (let i = 0; i < this.products.length; i++) {

        if (this.products[i].category == this.filterModal.filterValue.Category && this.products[i].gender == this.filterModal.filterValue.Gender && this.products[i].brand == this.filterModal.filterValue.Brand && this.products[i].price >= this.filterModal.filterValue.Price[0] && this.products[i].price <= this.filterModal.filterValue.Price[1]) {
        this.filteredProducts.push(this.products[i]);
      }
    }
    }


  }
 

 /* initializeForm(user: User) {
    this.updateUserForm = this.fb.group({
      firstName: [user.FirstName],
      lastName: [user.LastName]

    });
  }

  updateUser() {

    const editedUser = new User(
      this.users.Id,
      this.users.Email,
      this.updateUserForm.value.lastName,
      this.updateUserForm.value.firstName,
      this.users.BirthDate,

    );



    this.api.updateUser(editedUser)
      .subscribe(() => { })

  }*/
  showMeasure() {
    this.findMeasureModal.initialize();
  }
  showFilter() {
    this.filterModal.initialize();
   /* console.log(this.filterModal.filterValue);;
    console.log(this.filterModal.isFilter)
   */
   
  }
  onSuccess(message,product: any) {
    this.service.success('Done', message, {
      position: ['top', 'right'],
      timeOut: 2000,
      animate: 'fade',
      showProgressBar: true,
    
     
    });
 
    //console.log(product.id);
    product.quantity = this.getProductQuantity(product.id);
    product.measure = this.measure;
    console.log(this.getProductQuantity(product.id));
    this.cartService.add(product);
   // console.log("am adaugat");
  }
  selectChangeHandler(event: any) {
    this.selectedOrder = event.target.value;
    if (this.selectedOrder == "desc") {
      this.api1['orderDescByPrice']().subscribe((data: Equipment[]) => {
        this.products = data;
      
        // console.log(data);
      });
      }
    
    else if (this.selectedOrder == "cresc") {
      this.api1['orderCrescByPrice']().subscribe((data: Equipment[]) => {
        this.products = data;
        // console.log(data);
      });
      
    }
  //  console.log(this.selectedOrder);
  }
  chooseProductMeasure(event: any, product: any) {
    product.measure = event.target.value;
   // console.log(product.measure);
    this.measure = product.measure;
    console.log(this.measure);
    
    

  }
 

 getProductQuantity(productId: string) {
    for (let i = 0; i < this.productQuantities.length; i++) {
      if (this.productQuantities[i].productId == productId) {
        return this.productQuantities[i].quantity;
      }
    }
    return 0;
  }
  
 inc(productId: string) {
    var found = new Boolean(false);
    for (let i = 0; i < this.productQuantities.length; i++) {
      if (this.productQuantities[i].productId == productId) {
        this.productQuantities[i].quantity += 1;
        found = true;
      }
    }

    if (found == false) {
      var newProduct = new ProductQuantity(productId, 1);
      this.productQuantities.push(newProduct);
    }

   // this.qty = this.qty + 1;

    

 /*   const editedProduct = new Equipment(
      product.Id,
      product.ProductName,
      product.Category,
      product.Price,
      product.Description,
      product.Image,
      product.Gender,
      product.Quantity

    );



    this.cartService.updateProduct(editedProduct)
      .subscribe(() => { })*/
    //console.log(this.qty);
   
  }

 dec(productId: string)
    {
      var found = new Boolean(false);
      for (let i = 0; i < this.productQuantities.length; i++) {
        if (this.productQuantities[i].productId == productId && this.productQuantities[i].quantity!=0) {
          this.productQuantities[i].quantity -= 1;
          found = true;
        }
      }

      if (found == false) {
        var newProduct = new ProductQuantity(productId, 0);
        this.productQuantities.push(newProduct);
      }
  }
    
 


}
