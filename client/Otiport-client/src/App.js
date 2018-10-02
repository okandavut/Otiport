import * as React from "react";
import { Switch, Route } from "react-router-dom";
import HomePageContainer from "./containers/HomePageContainer";
import LoginPageContainer from "./containers/LoginPageContainer";

export default class App extends React.Component {
  render() {
    return (
      <Switch>
        <Route path={"/"} component={LoginPageContainer} />
        <Route path={"/Login"} component={LoginPageContainer} />
      </Switch>
    );
  }
}
