import * as React from "react";
import { connect } from "react-redux";
import CreateUser from "../../stories/screens/CreateUser";
import { createUser } from "./actions";
export interface Props {
  fetchUser: Function;
  isLoading: boolean;
}
export interface State {}

class createUserContainer extends React.Component<Props, State> {
    createUser() {
    this.props.createUser("okan",'davut', "okandavut@mail.com");
  }

  render() {
    return <CreateUser createUser={this.createUser} isLoading={this.props.isLoading} />;
  }
}

function bindAction(dispatch) {
  return {
    createUser: (username, password) => dispatch(createUser(name,surname, email))
  };
} 

const mapStateToProps = state => ({
  isLoading: state.createUserReducer.isLoading
});

export default connect(
  mapStateToProps,
  bindAction
)(createUserContainer);
