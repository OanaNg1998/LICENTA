export class OrderProduct {
  Id: string;
  Quantity: number;
  Name: string;
  Price: number;
  Image: string;
  Measure: string;
 
  constructor(Id?: string, Quantity?: number, Name?: string,  Price?: number, Image?: string, Measure?: string) {
    this.Id = Id;
    this.Name = Name;
    this.Quantity = Quantity;
    this.Price = Price;
    this.Image = Image;
    this.Measure = Measure;



  }

}
