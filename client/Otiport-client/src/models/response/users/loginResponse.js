import ResponseBase from "../../responseBase";

export default class LoginResponse extends ResponseBase {
  constructor(obj) {
      this.accessToken = obj.accessToken;
  }

  accessToken: string;
}
