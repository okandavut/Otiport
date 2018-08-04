import * as React from "react";
import { Switch, Route } from "react-router-dom";
import HomePageContainer from "./containers/HomePageContainer";

export default class App extends React.Component {
  render() {
    return (
      <Switch>
        <Route path={"/"} component={HomePageContainer} />
      </Switch>
    );
  }
}
