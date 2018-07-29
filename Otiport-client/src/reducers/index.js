import { combineReducers } from "redux";

import HomePageReducer from "../containers/HomePageContainer/reducer";

export default combineReducers({
  homePageReducer: HomePageReducer
});
