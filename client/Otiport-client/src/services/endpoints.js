class Endpoints {
  baseApiPath = "https://localhost:44398/";

  users = this.baseApiPath + "/users";
  adress = this.baseApiPath + "/address-informations";
  login = this.users + "/login";
  createUser = this.users + "/register";
  getCountries = this.adress + "/countries";
}

export default new Endpoints();
