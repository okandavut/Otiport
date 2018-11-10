import axios from "axios";
import endpoints from "./endpoints";
import LoginRequest from "../models/request/users/loginRequest";
import LoginResponse from "../models/response/users/loginResponse";
import CreateUserRequest from "../models/request/users/createUserRequest";
import CreateUserResponse from "../models/response/users/createUserResponse";
import GetCountriesResponse from "../models/response/common/getCountriesResponse";
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

  createUser(model: CreateUserRequest) {
    return this.client
      .post(endpoints.createUser, model)
      .then(res => new CreateUserResponse(res.data));
  }
  getCountries() {
    return this.client
      .get(endpoints.getCountries)
      .then(res => new GetCountriesResponse(res.data));
  }
}

export default new APIService();
