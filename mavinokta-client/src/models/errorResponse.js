class Error {
  constructor(obj) {
    this.title = obj.title;
    this.detail = obj.detail;
  }

  title: string;
  detail: string;
}

export default class ErrorResponse {
  constructor(obj) {
    this.errorCode = obj.errorCode;
    this.errors = obj.errors;
    this.errorMessage = obj.errorMessage;
  }

  errorMessage: string;
  errorCode: number;
  errors: Array<Error>;
}
