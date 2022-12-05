export interface IPersona {
  id?: number,
  name?:string,
  phoneNumber?:string,
  email?:string,
  address?: {
    addressId?:number,
    street?:string,
    city?:string,
    number?:string,

  }
}
