export default class UserModel {
  constructor(obj) {
    this.emailAddress = obj.emailAddress;
    this.password = obj.password;
    this.userName = obj.userName;
    this.firstName = obj.firstName;
    this.middleName = obj.middleName;
    this.lastName = obj.lastName;
    this.birthDate = obj.birthDate;
    this.country = obj.country;
    this.city = obj.city;
    this.district = obj.district;
  }
  emailAddress: string;
  password: string;
  userName: string;
  firstName: string;
  middleName: string;
  lastName: string;
  birthDate: dateTime;
  country: string;
  city: string;
  district: string;
}
