


export class User {
  Id: string;
  
  Email: string;
  FirstName: string;
  LastName: string;
  BirthDate: Date;


  constructor(Id?: string,Email?: string, LastName?: string, FirstName?: string, BirthDate?: Date) {
    this.Id = Id;
    this.Email = Email;
    this.FirstName = FirstName;
    this.LastName = LastName; 
    this.BirthDate = BirthDate;
   
  }

 

}
