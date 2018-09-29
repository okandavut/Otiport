import * as React from "react";
import { connect } from "react-redux";
import LoginPage from "../../stories/screens/LoginPage";
import { login } from "./actions";
export interface Props {
  isLoading: boolean;
  accessToken: string;
}
export interface State {}

class LoginPageContainer extends React.Component<Props, State> {
  login(emailAddress, password) {
    login(emailAddress, password);
  }

  render() {
    return <LoginPage login={this.login} isLoading={this.props.isLoading} />;
  }
}

function bindAction(dispatch) {
  return {
    login: (username, password) => dispatch(login(username, password))
  };
}

const mapStateToProps = state => ({
  isLoading: state.loginPageReducer.isLoading,
  accessToken: state.loginPageReducer.accessToken
});

export default connect(
  mapStateToProps,
  bindAction
)(LoginPageContainer);
