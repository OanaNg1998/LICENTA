export class Reservation {
  ReservationDate: Date;
  Email: string;
  OwnerName: string;
  ClassName: string;
  NumberPersons: number;


  constructor(ReservationDate?: Date, Email?: string, OwnerName?: string,ClassName?:string,NumberPersons?:number) {
    this.ReservationDate = ReservationDate;
    this.Email = Email;
    this.OwnerName = OwnerName;
    this.ClassName = ClassName;
    this.NumberPersons = NumberPersons;
   



  }

}
