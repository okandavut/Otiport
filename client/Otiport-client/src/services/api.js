import axios from "axios";
import endpoints from "./endpoints";
import LoginRequest from "../models/request/users/loginRequest";
import LoginResponse from "../models/response/users/loginResponse";
class APIService {
  client = null;
  constructor() {
    this.client = axios.create({
      baseURL: endpoints.baseApiPath,
      headers: {
        "Content-Type": "application/json"
      }
    });
  }

  login(model: LoginRequest) {
    return this.client
      .post(endpoints.login, model)
      .then(res => new LoginResponse(res.data));
  }
}

export default new APIService();
