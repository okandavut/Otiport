import types from "../../common/types";

export function changeIsLoading(isLoading: boolean) {
  return {
    type: types.IS_LOADING,
    value: isLoading
  };
}

export function createUser(name,surname,email) {
  return dispatch => {
    dispatch(changeIsLoading(true));

    //Call Api for register

    dispatch(changeIsLoading(false));
  };
}
