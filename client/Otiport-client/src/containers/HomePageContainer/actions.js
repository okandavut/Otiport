import types from "../../common/types";

export function changeIsLoading(isLoading: boolean) {
  return {
    type: types.IS_LOADING,
    value: isLoading
  };
}

export function fetchUser(username, password) {
  return dispatch => {
    dispatch(changeIsLoading(true));

    //Call Api

    dispatch(changeIsLoading(false));
  };
}
