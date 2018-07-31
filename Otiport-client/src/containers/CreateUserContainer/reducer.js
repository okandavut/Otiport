import types from "../../common/types";
const state = {
  isLoading: false,
  hasError: false,
  errors: [],
  username: ""
};

export default function(state: any = state, action: Function) {
  switch (action.type) {
    case types.IS_LOADING:
      return {
        ...state,
        isLoading: action.payload
      };
  }
}
