import { Output } from '@angular/core';
import { EventEmitter } from '@angular/core';
import { ViewChild } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { Equipment } from '../../../models/equipment';
import { ShopService } from '../../../shop.service';
import { Options } from 'ng5-slider';
import { Filter } from '../../../models/filter';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-filtermodal',
  templateUrl: './filtermodal.component.html',
  styleUrls: ['./filtermodal.component.css']
})
export class FiltermodalComponent implements OnInit {

  @ViewChild('filterModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();
  filterProducts: Array<Equipment> = new Array<Equipment>();
  filterBrandsProducts: Array<Equipment> = new Array<Equipment>();
  isTrousers: number=0;
  isTshirt: number = 0;
  isShorts: number = 0;
  isSneakers: number = 0;
  filterValue: Filter = new Filter();
  isFilter: number = 0;
  selected: any;


  keyword = 'brand';
  
  public data$: Observable<any[]>;
  constructor(private api1: ShopService) { }

  selectEvent(item) {
    this.selected = item.brand;
    console.log(this.selected);

  } 
  ngOnInit(): void {
    this.api1['getProducts']().subscribe((data: Equipment[]) => {
      this.filterProducts = data;
      // console.log(data);
    })
    this.api1['getBrandsForSearchbarFilter']().subscribe((data: Equipment[]) => {
      this.filterBrandsProducts = data;
      // console.log(data);
    })

   
  }

  
  getValues(val) {
   // console.log(val);
   
  }
  setFilterValues(val) {
    this.filterValue.Category = val.category;
   // console.log(this.filterValue.Category);
    this.filterValue.Price = val.price;
    this.filterValue.Gender = val.gender;
    this.filterValue.Brand = this.selected;
   // console.log(this.filterValue.Gender);
    this.isFilter = 1;
    this.change.emit('filtrat');
    //console.log(this.isFilter);
  //  console.log(this.filterValue);
    this.modal.hide();

  }
  selectChangeHandler(event: any) {
   
    if (event.target.value == "trousers") {
      this.isTrousers = 1;
      this.isTshirt = 0;
      this.isShorts = 0;
      this.isSneakers = 0;
    }
    else if (event.target.value == "tshirt") {
      this.isTrousers = 0;
      this.isTshirt = 1;
      this.isShorts = 0;
      this.isSneakers = 0;
    }
    else if (event.target.value == "shorts") {
      this.isTrousers = 0;
      this.isTshirt = 0;
      this.isShorts = 1;
      this.isSneakers = 0;
    }
    else if (event.target.value == "sneakers") {
      this.isTrousers = 0;
      this.isTshirt = 0;
      this.isShorts = 0;
      this.isSneakers = 1;

    }

   

    
    //  console.log(this.selectedOrder);
  }
  value: number = 40;
  highValue: number = 60;
  options: Options = {
    floor: 0,
    ceil: 300
  };
  initialize(): void {

    this.modal.show();

  }

}
