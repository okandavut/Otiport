import * as React from "react";
import "bulma/css/bulma.css";
import 'bootstrap/dist/css/bootstrap.css';
import '../src/App.css';
import { Switch, Route } from "react-router-dom";
import HomePageContainer from "./containers/HomePageContainer";
import LoginPageContainer from "./containers/LoginPageContainer";
import CreateUserContainer from "./containers/CreateUserContainer";
import MainPageContainer from "./containers/MainPageContainer";

export default class App extends React.Component {
  render() {
    return (
      <Switch>
        <Route exact path={"/"} component={HomePageContainer} />
        <Route path={"/Login"} component={LoginPageContainer} />
        <Route path={"/CreateUser"} component={CreateUserContainer} />
        <Route path={"/MainPage"} component={MainPageContainer} />
      </Switch>
    );
  }
}
