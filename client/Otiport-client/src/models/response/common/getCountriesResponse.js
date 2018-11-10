import ResponseBase from "../../responseBase";

export default class GetCountriesResponse extends ResponseBase {
  constructor(obj) {
    super(obj);
    this.listOfCountries = obj.listOfCountries;
  }

  listOfCountries: [];
}
