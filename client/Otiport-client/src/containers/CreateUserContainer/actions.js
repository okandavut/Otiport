import types from "../../common/types";
import APIService from "../../services/api";
import CreateUserRequest from "../../models/request/users/createUserRequest";
import UserModel from "../../models/request/users/userModel";

export function changeIsLoading(isLoading: boolean) {
  return {
    type: types.IS_LOADING,
    value: isLoading
  };
}

export function createUser(
  userName,
  password,
  emailAddress,
  firstName,
  middleName,
  lastName,
  birthDate,
  country,
  city,
  district
) {
  return dispatch => {
    dispatch(changeIsLoading(true));
    APIService.createUser(
      new CreateUserRequest({
        userModel: new UserModel({
          userName: userName,
          password: password,
          emailAddress: emailAddress,
          firstName: firstName,
          middleName: middleName,
          lastName: lastName,
          birthDate: birthDate,
          country: country,
          city: city,
          district: district
        })
      })
    ).then(res => {
      if (!res.isSuccess) {
        console.log("hataa");
      }
    });
    dispatch(changeIsLoading(false));
  };
}

export function getCountries(countryId) {
  return dispatch => {
    dispatch(changeIsLoading(true));
    APIService.getCountries().then(res => {
      if (!res.isSuccess) {
        console.log("aa");
      }
    });
    dispatch(changeIsLoading(false));
  };
}
