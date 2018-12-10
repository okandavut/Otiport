import types from "../../common/types";
const initialState = {
  isLoading: false,
  hasError: false,
  errors: [],
  accessToken: "",
  redirect: false
};

export default function(state: any = initialState, action: Function) {
  switch (action.type) {
    case types.IS_LOADING:
      return {
        ...state,
        isLoading: action.isLoading
      };
    case types.SET_ACCESS_TOKEN:
      return {
        ...state,
        accessToken: action.accessToken
      };
    case types.HAS_ERROR:
      return {
        ...state,
        hasError: true,
        errors: [action.errors]
      };
    case types.SET_REDIRECT:
      return {
        ...state,
        redirect: action.redirect
      };
    default:
      return {
        ...state
      };
  }
}
