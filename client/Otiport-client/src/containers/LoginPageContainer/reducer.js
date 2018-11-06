import types from "../../common/types";
const initialState = {
  isLoading: false,
  hasError: false,
  errors: [],
  accessToken: ""
};

export default function(state: any = initialState, action: Function) {
  switch (action.type) {
    case types.IS_LOADING:
      return {
        ...state,
        isLoading: action.payload
      };
    case types.SET_ACCESS_TOKEN:
      return {
        ...state,
        accessToken: action.payload
      };
    case types.HAS_ERROR:
      return {
        ...state,
        hasError: true,
        errors: [action.payload]
      };
    default:
      return {
        ...state
      };
  }
}
