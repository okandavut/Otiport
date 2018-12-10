import types from "../../common/types";

export function changeIsLoading(isLoading: boolean) {
  return {
    type: types.IS_LOADING,
    value: isLoading
  };
}
