import types from "../../common/types";
import APIService from "../../services/api";
import LoginRequest from "../../models/request/users/loginRequest";

export function changeIsLoading(isLoading: boolean) {
  return {
    type: types.IS_LOADING,
    value: isLoading
  };
}

export function hasError(error: string) {
  return {
    type: types.HAS_ERROR,
    error: error
  };
}

export function setAccessToken(accessToken: string) {
  return {
    type: types.SET_ACCESS_TOKEN,
    accessToken: accessToken
  };
}

export function login(emailAddress, password) {
  return dispatch => {
    dispatch(changeIsLoading(true));

    APIService.login(
      new LoginRequest({
        emailAddress: emailAddress,
        password: password
      })
    ).then(res => {
      if (!res.isSuccess) {
        dispatch(hasError("Invalid username or password"));
      }
      dispatch(setAccessToken(res.accessToken));
      dispatch(changeIsLoading(false));
    });
  };
}
