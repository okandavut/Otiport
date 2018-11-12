import types from "../../common/types";
const intializedState = {
  isLoading: false,
  hasError: false,
  errors: [],
  countries: [],
  cities: [],
  districts: []
};

export default function(state: any = intializedState, action: Function) {
  switch (action.type) {
    case types.IS_LOADING:
      return {
        ...state,
        isLoading: action.isLoading
      };
    case types.SET_COUNTRIES:
      return {
        ...state,
        countries: action.countries,
        cities: [],
        districts: []
      };
    case types.SET_CITIES:
      return {
        ...state,
        cities: action.cities,
        districts: []
      };
    case types.SET_DISTRICTS:
      return {
        ...state,
        districts: action.districts
      };
    default:
      return state;
  }
}
