import { combineReducers } from "redux";
import HomePageReducer from "../containers/HomePageContainer/reducer";
import CreateUserPageReducer from "../containers/HomePageContainer/reducer";
export default combineReducers({
  homePageReducer: HomePageReducer,
  createUserPageReducer: CreateUserPageReducer
});
