import * as React from "react";

export interface Props {
  isLoading: boolean;
  login: Function;
}
export interface State {
  count: number;
}

export default class LoginPage extends React.Component<Props, State> {
  constructor(props) {
    super(props);
  }

  render() {
    if (this.props.isLoading) {
      return (
        <div>
          <span>Loading....</span>
        </div>
      );
    }
    return (
      <div>
        HELLO HOMEPAGE
        <br />HOME PAGE - COMPONENTI
      </div>
    );
  }
}
