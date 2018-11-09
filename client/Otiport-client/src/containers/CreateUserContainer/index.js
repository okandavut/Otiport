import * as React from "react";
import { connect } from "react-redux";
import CreateUser from "../../stories/screens/CreateUser";
import { createUser, getCountries } from "./actions";
export interface Props {
  createUser: Function;
  getCountries: Function;
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
  getCountries = () => {
    this.props.getCountries();
  };

  render() {
    return (
      <CreateUser
        createUser={this.createUser.bind(this)}
        getCountries={this.getCountries.bind(this)}
        isLoading={false}
      />
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
      ),
    getCountries: () => dispatch(getCountries())
  };
}

const mapStateToProps = state => ({
  isLoading: state.createUserPageReducer.isLoading
});

export default connect(
  mapStateToProps,
  bindAction
)(createUserContainer);
