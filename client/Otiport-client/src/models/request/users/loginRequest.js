export default class LoginRequest {
  constructor(obj) {
    this.emailAddress = obj.emailAddress;
    this.password = obj.password;
  }
  
  emailAddress: string;
  password: string;
}
