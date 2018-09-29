class Endpoints {
  baseApiPath = "";

  users = this.baseApiPath + "/users";
  login = this.users + "/logn";
  register = this.users + "/register";
}

export default new Endpoints();