import * as React from "react";
import { connect } from "react-redux";
import HomePage from "../../stories/screens/HomePage";
import { fetchUser } from "./actions";
export interface Props {
  fetchUser: Function;
  isLoading: boolean;
}
export interface State {}

class HomePageContainer extends React.Component<Props, State> {
  login() {
    this.props.fetchUser("peacecwz", "12345678");
  }

  render() {
    return <HomePage login={this.login} isLoading={this.props.isLoading} />;
  }
}

function bindAction(dispatch) {
  return {
    fetchUser: (username, password) => dispatch(fetchUser(username, password))
  };
}

const mapStateToProps = state => ({
  isLoading: state.homePageReducer.isLoading
});

export default connect(
  mapStateToProps,
  bindAction
)(HomePageContainer);
