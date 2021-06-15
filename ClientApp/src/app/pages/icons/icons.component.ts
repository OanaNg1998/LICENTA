import { ViewChild } from "@angular/core";
import { Component, OnInit } from "@angular/core";
import { NutritionProduct } from "../../models/nutritionproduct";
import { ShopService } from "../../shop.service";
import { NutritionfiltermodalComponent } from "./nutritionfiltermodal/nutritionfiltermodal.component";

@Component({
  selector: "app-icons",
  templateUrl: "icons.component.html",
  styleUrls: ['./icons.component.css']
})
export class IconsComponent implements OnInit {

  public nutritionproducts: any;

  @ViewChild('nutritionfilterModal', { static: false }) nutritionfilterModal: NutritionfiltermodalComponent;
  constructor(private api1: ShopService) { }

  ngOnInit() {
    this.api1['getNutritionProducts']().subscribe((data: NutritionProduct[]) => {
      this.nutritionproducts = data;
      // console.log(data);
    })}
  showNutritionFilter() {
    this.nutritionfilterModal.initialize();
   

  }
}
