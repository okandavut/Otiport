import types from "../../common/types";
import APIService from "../../services/api";
import CreateUserRequest from "../../models/request/users/createUserRequest";
import UserModel from "../../models/request/users/userModel";

export function changeIsLoading(isLoading: boolean) {
  return {
    type: types.IS_LOADING,
    isLoading: isLoading
  };
}

export function setCountries(countries: Array<Object>) {
  return {
    type: types.SET_COUNTRIES,
    countries: countries
  };
}

export function setCities(cities: Array<Object>) {
  return {
    type: types.SET_CITIES,
    cities: cities
  };
}

export function setDistricts(districts: Array<Object>) {
  return {
    type: types.SET_DISTRICTS,
    districts: districts
  };
}

export function setRedirect(redirect: boolean) {
  return {
    type: types.SET_REDIRECT,
    redirect: redirect
  };
}
export function hasError(error: string) {
  return {
    type: types.HAS_ERROR,
    error: error
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
        dispatch(hasError("Problem occured"));
      } else {
        dispatch(setRedirect(true));
      }
    });
    dispatch(changeIsLoading(false));
  };
}

export function getCountries() {
  return dispatch => {
    dispatch(changeIsLoading(true));
    APIService.getCountries().then(res => {
      if (!res.isSuccess) {
        console.log("aa");
      }
      dispatch(setCountries(res.listOfCountries));
      dispatch(changeIsLoading(false));
    });
  };
}

export function getCities(countryId) {
  return dispatch => {
    dispatch(changeIsLoading(true));
    APIService.getCities(countryId).then(res => {
      if (!res.isSuccess) {
        console.log("hata");
      }
      dispatch(setCities(res.listOfCities));
      dispatch(changeIsLoading(false));
    });
  };
}

export function getDistricts(cityId) {
  return dispatch => {
    dispatch(changeIsLoading(true));
    APIService.getDistricts(cityId).then(res => {
      if (!res.isSuccess) {
        console.log("hata");
      }
      dispatch(setDistricts(res.districts));
      dispatch(changeIsLoading(false));
    });
  };
}
