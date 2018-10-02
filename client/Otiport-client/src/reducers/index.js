import { combineReducers } from "redux";
import HomePageReducer from "../containers/HomePageContainer/reducer";
import CreateUserPageReducer from "../containers/HomePageContainer/reducer";
import LoginPageReducer from "../containers/LoginPageContainer/reducer";
export default combineReducers({
  homePageReducer: HomePageReducer,
  createUserPageReducer: CreateUserPageReducer,
  loginPageReducer: LoginPageReducer
});
