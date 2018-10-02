import ResponseBase from "../../responseBase";

export default class LoginResponse extends ResponseBase {
   constructor(obj) {
      super();
      this.accessToken = obj.accessToken;
   }

  accessToken: string;
}
