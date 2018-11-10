import types from "../../common/types";
const intializedState = {
  isLoading: false,
  hasError: false,
  errors: [],
  countries: []
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
        countries: action.countries
      };
    default:
      return state;
  }
}
