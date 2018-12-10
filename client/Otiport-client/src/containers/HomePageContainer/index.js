import * as React from "react";
import { connect } from "react-redux";
import HomePage from "../../stories/screens/HomePage";
export interface Props {
  isLoading: boolean;
}
export interface State {}

class HomePageContainer extends React.Component<Props, State> {
  render() {
    return <HomePage login={this.login} isLoading={this.props.isLoading} />;
  }
}

function bindAction(dispatch) {
  return {};
}

const mapStateToProps = state => ({
  isLoading: state.homePageReducer.isLoading
});

export default connect(
  mapStateToProps,
  bindAction
)(HomePageContainer);
