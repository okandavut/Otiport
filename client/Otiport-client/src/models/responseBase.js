export default class ResponseBase {
  constructor(props) {
    this.isSuccess = props.isSuccess;
    this.statusCode = props.statusCode;
  }

  isSuccess: boolean;
  statusCode: number;
}
