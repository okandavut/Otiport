class Endpoints {
  baseApiPath = "https://localhost:5001/";

  users = this.baseApiPath + "/users";
  address = this.baseApiPath + "address-informations";
  login = this.users + "/login";
  createUser = this.users + "/register";
  getCountries = this.address + "/countries";
}

export default new Endpoints();
