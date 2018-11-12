import * as React from "react";
import { connect } from "react-redux";
import CreateUser from "../../stories/screens/CreateUser";
import { createUser, getCountries, getCities, getDistricts } from "./actions";
export interface Props {
  createUser: Function;
  getCountries: Function;
  getCities: Function;
  getDistricts: Function;
  isLoading: boolean;
  countries: Array<Object>;
  cities: Array<Object>;
  districts: Array<Object>;
}
export interface State {}

class createUserContainer extends React.Component<Props, State> {
  componentWillMount() {
    this.props.getCountries();
  }

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
  
  getCities(countryId) {
    this.props.getCities(countryId);
  }

  getDistricts(cityId) {
    this.props.getDistricts(cityId);
  }

  render() {
    return (
      <CreateUser
        createUser={this.createUser.bind(this)}
        countries={this.props.countries}
        getCities={this.getCities.bind(this)}
        cities={this.props.cities}
        getDistricts={this.props.getDistricts.bind(this)}
        districts={this.props.districts}
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
    getCountries: () => dispatch(getCountries()),
    getCities: countryId => dispatch(getCities(countryId)),
    getDistricts: cityId => dispatch(getDistricts(cityId))
  };
}

const mapStateToProps = state => ({
  isLoading: state.createUserPageReducer.isLoading,
  countries: state.createUserPageReducer.countries,
  cities: state.createUserPageReducer.cities,
  districts: state.createUserPageReducer.districts
});

export default connect(
  mapStateToProps,
  bindAction
)(createUserContainer);
