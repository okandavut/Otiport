class Endpoints {
  baseApiPath = "";

  users = this.baseApiPath + "/users";
  login = this.users + "/login";
  register = this.users + "/register";
}

export default new Endpoints();