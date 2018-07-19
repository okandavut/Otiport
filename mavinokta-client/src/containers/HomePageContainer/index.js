import * as React from "react";
import HomePage from "../../stories/screens/HomePage";

export interface Props {}
export interface State {}

class HomePageContainer extends React.Component<Props, State> {
  render() {
    return <HomePage />;
  }
}

export default HomePageContainer;