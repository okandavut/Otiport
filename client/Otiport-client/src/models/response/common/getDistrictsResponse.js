import ResponseBase from "../../responseBase";

export default class GetDistrictsResponse extends ResponseBase {
  constructor(obj) {
    super(obj);
    this.districts = obj.districts;
  }

  districts: [];
}
