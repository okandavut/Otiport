import * as React from "react";
import { connect } from "react-redux";
import LoginPage from "../../stories/screens/LoginPage";
import { login } from "./actions";
import { Redirect } from "react-router";
export interface Props {
  isLoading: boolean;
  accessToken: string;
  login: Function;
  redirect: boolean;
}
export interface State {}

class LoginPageContainer extends React.Component<Props, State> {
  login(emailAddress, password) {
    this.props.login(emailAddress, password);
  }

  render() {
    return (
      <div>
        <LoginPage
          login={this.login.bind(this)}
          isLoading={this.props.isLoading}
        />
        {this.props.redirect && <Redirect to={"/MainPage"} />}
      </div>
    );
  }
}

function bindAction(dispatch) {
  return {
    login: (username, password) => dispatch(login(username, password))
  };
}

const mapStateToProps = state => ({
  isLoading: state.loginPageReducer.isLoading,
  accessToken: state.loginPageReducer.accessToken,
  redirect: state.loginPageReducer.redirect
});

export default connect(
  mapStateToProps,
  bindAction
)(LoginPageContainer);
