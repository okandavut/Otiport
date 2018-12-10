import * as React from "react";
import { connect } from "react-redux";
import MainPage from "../../stories/screens/MainPage";
export interface Props {}
export interface State {}

class MainPageContainer extends React.Component<Props, State> {
  render() {
    return <MainPage login={this.login} isLoading={this.props.isLoading} />;
  }
}

const mapStateToProps = state => ({
  isLoading: state.mainPageReducer.isLoading
});
function bindAction(dispatch) {
  return {};
}
export default connect(
  mapStateToProps,
  bindAction
)(MainPageContainer);
