export class ShopItems {
  Id: string;
  Name: string;
  Quantity: number;
  Price: number;
  Image: string;
  Measure: string;


  constructor(Id?: string, Name?: string, Quantity?: number, Price?: number, Image?: string, Measure?:string) {
    this.Id = Id;
    this.Name = Name;
    this.Quantity = Quantity;
    this.Price = Price;
    this.Image = Image;
    this.Measure = Measure;



  }

}
