import * as React from "react";

export interface Props {}
export interface State {}

export default class MainPage extends React.Component<Props, State> {
  constructor(props) {
    super(props);
    this.state = {
      count: 0
    };
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
        <div className="container" />
        ANA SAYFAYA HOSGELDINIZ
      </div>
    );
  }
}
