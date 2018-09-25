import * as React from "react";

export interface Props {
  isLoading: boolean;
  createUser: Function;
}
export interface State {}

export default class CreateUser extends React.Component<Props, State> {
  constructor(props) {
    super(props);
    this.state = {};
  }

  render() {
    if (this.props.isLoading) {
      return (
      <div>Loading...</div> 
      );
    }
    return (
        <div> SELAMLAR </div>
    )
  }
}
