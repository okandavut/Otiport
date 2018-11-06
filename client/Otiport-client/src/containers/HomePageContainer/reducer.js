import types from "../../common/types";
const initialState = {
  isLoading: false,
  hasError: false,
  errors: [],
  username: ""
};

export default function(state: any = initialState, action: Function) {
  switch (action.type) {
    case types.IS_LOADING:
      return {
        ...state,
        isLoading: action.payload
      };
    default:
      return {
        ...state
      };
  }
}
