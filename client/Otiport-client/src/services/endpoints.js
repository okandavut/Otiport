class Endpoints {
  baseApiPath = "http://localhost:5001/";

  users = this.baseApiPath + "/users";
  address = this.baseApiPath + "address-informations";
  login = this.users + "/login";
  createUser = this.users + "/register";
  getCountries = this.address + "/countries";
  getCities = this.address + "/cities";
  getDistricts = this.address + "/districts";
}

export default new Endpoints();
