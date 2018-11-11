import ResponseBase from "../../responseBase";

export default class GetCitiesResponse extends ResponseBase {
  constructor(obj) {
    super(obj);
    this.listOfCities = obj.listOfCities;
  }

  listOfCities: [];
}
