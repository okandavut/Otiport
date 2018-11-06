import types from "../../common/types";
const intializedState = {
  isLoading: false,
  hasError: false,
  errors: [],
  username: ""
};

export default function(state: any = intializedState, action: Function) {
  switch (action.type) {
    case types.IS_LOADING:
      return {
        ...state,
        isLoading: action.payload
      };
  }
}
