class Endpoints {
  baseApiPath = "http://localhost:5000";

  users = this.baseApiPath + "/users";
  login = this.users + "/login";
  register = this.users + "/register";
}

export default new Endpoints();