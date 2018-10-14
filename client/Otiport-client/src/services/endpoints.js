class Endpoints {
  baseApiPath = "https://localhost:44398/";

  users = this.baseApiPath + "/users";
  login = this.users + "/login";
  createUser = this.users + "/register";
}

export default new Endpoints();
