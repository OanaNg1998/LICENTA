export class Reservation {
  Date: Date;
  Email: string;
  OwnerName: string;
  ClassName: string;
  NumberPersons: number;


  constructor(Date?: Date, Email?: string, OwnerName?: string,ClassName?:string,NumberPersons?:number) {
    this.Date = Date;
    this.Email = Email;
    this.OwnerName = OwnerName;
    this.ClassName = ClassName;
    this.NumberPersons = NumberPersons;
   



  }

}
