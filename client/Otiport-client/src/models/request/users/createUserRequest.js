import UserModel from "./userModel";

export default class CreateUserRequest {
  constructor(obj) {
    this.userModel = obj.userModel;
  }

  userModel: UserModel;
}
