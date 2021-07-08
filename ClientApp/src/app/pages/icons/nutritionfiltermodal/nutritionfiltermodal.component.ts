import { ViewChild } from '@angular/core';
import { Output } from '@angular/core';
import { EventEmitter } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { Options } from 'ng5-slider';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { FilterNutrition } from '../../../models/filterNutrition';
import { NutritionProduct } from '../../../models/nutritionproduct';
import { ShopService } from '../../../shop.service';

@Component({
  selector: 'app-nutritionfiltermodal',
  templateUrl: './nutritionfiltermodal.component.html',
  styleUrls: ['./nutritionfiltermodal.component.css']
})
export class NutritionfiltermodalComponent implements OnInit {

  @ViewChild('nutritionfilterModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();
  filterNProducts: Array<NutritionProduct> = new Array<NutritionProduct>();
  isBar: number = 0;
  isPowder: number = 0;
  isOther: number = 0;
  filterNValue: FilterNutrition = new FilterNutrition();
  isNFilter: number = 0;
  constructor(private shopService: ShopService) { }

  ngOnInit(): void {
    this.shopService['getNutritionProducts']().subscribe((data: NutritionProduct[]) => {
      this.filterNProducts = data;
      //console.log(this.filterNProducts);
    })
  }
  value: number = 40;
  highValue: number = 60;
  options: Options = {
    floor: 0,
    ceil: 400
  };
  initialize(): void {

    this.modal.show();

  }
  getValues(val) {
    console.log(val);
  }
 
  setNFilterValues(val) {
    this.filterNValue.Category = val.category;
    this.filterNValue.Price = val.price;
    this.filterNValue.Brand = val.brand;
    console.log("filtreaza " + this.filterNValue);
    this.isNFilter = 1;
    this.change.emit('filtratN');
   
    this.modal.hide();

  }
  selectCategoryChangeHandler(event: any) {

    if (event.target.value == "protein bar") {
      this.isBar = 1;
      this.isPowder = 0;
      this.isOther = 0;
    }
    else if (event.target.value == "protein pouder") {
      this.isBar = 0;
      this.isPowder = 1;
      this.isOther = 0;
    }
    else if (event.target.value == "other") {
      this.isBar = 0;
      this.isPowder = 0;
      this.isOther = 1;
    }
  }
  selectBrandChangeHandler(event: any) {

    
  }
  closeModal() {
    this.modal.hide();
  }

}
