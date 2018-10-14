import * as React from "react";
import { connect } from "react-redux";
import CreateUser from "../../stories/screens/CreateUser";
import { createUser } from "./actions";
export interface Props {
  createUser: Function;
  isLoading: boolean;
}
export interface State {}

class createUserContainer extends React.Component<Props, State> {
  createUser(
    userName,
    password,
    emailAddress,
    firstName,
    middleName,
    lastName,
    birthDate,
    country,
    city,
    district
  ) {
    this.props.createUser(
      userName,
      password,
      emailAddress,
      firstName,
      middleName,
      lastName,
      birthDate,
      country,
      city,
      district
    );
  }

  render() {
    return (
      <CreateUser createUser={this.createUser.bind(this)} isLoading={false} />
    );
  }
}

function bindAction(dispatch) {
  return {
    createUser: (
      userName,
      password,
      emailAdress,
      firstName,
      middleName,
      lastName,
      birthDate,
      country,
      city,
      district
    ) =>
      dispatch(
        createUser(
          userName,
          password,
          emailAdress,
          firstName,
          middleName,
          lastName,
          birthDate,
          country,
          city,
          district
        )
      )
  };
}

const mapStateToProps = state => ({
  isLoading: state.createUserPageReducer.isLoading
});

export default connect(
  mapStateToProps,
  bindAction
)(createUserContainer);
