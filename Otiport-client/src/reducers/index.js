import { combineReducers } from "redux";
import HomePageReducer from "../containers/HomePageContainer/reducer";
import CreateUserReducer from "../containers/CreateUserContainer/reducer";

export default combineReducers({
  homePageReducer: HomePageReducer,
  createUserReducer: CreateUserReducer
});
