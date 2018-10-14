import * as React from "react";

export interface Props {
  isLoading: boolean;
  createUser: Function;
}
export interface State {}

export default class CreateUser extends React.Component<Props, State> {
  constructor(props) {
    super(props);
    this.state = {
      country: "",
      city: "",
      district: "",
      username: "",
      lastName: "",
      emailAddress: "",
      firstName: "",
      birthDate: "",
      password: "",
      middleName: ""
    };
  }
  handleChange = event => {
    this.setState({
      [event.target.id]: event.target.value
    });
  };
  sendLogin = () => {
    console.log(this.state);
    this.props.createUser(
      this.state.username,
      this.state.password,
      this.state.emailAddress,
      this.state.firstName,
      this.state.middleName,
      this.state.lastName,
      this.state.birthDate,
      this.state.country,
      this.state.city,
      this.state.district
    );
  };
  render() {
    if (this.props.isLoading) {
      return <div>Loading...</div>;
    }
    return (
      <div className="container">
        <div className="field">
          <label className="label">Kullanıcı Adı</label>
          <div className="control">
            <input
              className="input"
              type="text"
              placeholder="Kullanıcı Adı"
              id="username"
              value={this.state.username}
              onChange={this.handleChange}
            />
          </div>
        </div>
        <div className="field">
          <label className="label">Şifre</label>
          <div className="control">
            <input
              className="input"
              type="text"
              placeholder="Şifre"
              id="password"
              value={this.state.password}
              onChange={this.handleChange}
            />
          </div>
        </div>
        <div className="field">
          <label className="label">Email Adres</label>
          <div className="control">
            <input
              id="emailAddress"
              className="input"
              type="text"
              placeholder="Email Adres"
              value={this.state.emailAddress}
              onChange={this.handleChange}
            />
          </div>
        </div>
        <div className="field">
          <label className="label">Ad</label>
          <div className="control">
            <input
              className="input"
              type="text"
              placeholder="Ad"
              id="firstName"
              value={this.state.firstName}
              onChange={this.handleChange}
            />
          </div>
        </div>
        <div className="field">
          <label className="label">Orta Ad</label>
          <div className="control">
            <input
              className="input"
              type="text"
              placeholder="Orta ad ( varsa )"
              id="middleName"
              value={this.state.middleName}
              onChange={this.handleChange}
            />
          </div>
        </div>
        <div className="field">
          <label className="label">Soyad</label>
          <div className="control">
            <input
              className="input"
              type="text"
              placeholder="Soyad"
              id="lastName"
              value={this.state.lastName}
              onChange={this.handleChange}
            />
          </div>
        </div>{" "}
        <div className="field">
          <label className="label">Doğum Tarihi</label>
          <div className="control">
            <input
              className="input"
              type="date"
              placeholder="Doğum tarihinizi bilginizi giriniz."
              id="birthDate"
              value={this.state.birthDate}
              onChange={this.handleChange}
            />
          </div>
        </div>
        <div className="field">
          <label className="label">Ülke Seç</label>
          <div className="control">
            <div className="select">
              <select
                id="country"
                value={this.state.country}
                onChange={this.handleChange}
              >
                <option>Ülke Seçiniz</option>
                <option>Türkiye</option>
              </select>
            </div>
          </div>
        </div>
        <div className="field">
          <label className="label">Şehir Seç</label>
          <div className="control">
            <div className="select">
              <select
                id="city"
                value={this.state.city}
                onChange={this.handleChange}
              >
                <option>Şehir Seçiniz</option>
                <option>İzmir</option>
                <option>İstanbul</option>
              </select>
            </div>
          </div>
        </div>
        <div className="field">
          <label className="label">İlçe</label>
          <div className="control">
            <div className="select">
              <select
                id="district"
                value={this.state.district}
                onChange={this.handleChange}
              >
                <option>İlçe Seçiniz</option>
                <option>Karşıyaka</option>
                <option>Konak</option>
              </select>
            </div>
          </div>
        </div>
        <div className="field is-grouped">
          <div className="control">
            <button className="button is-link" onClick={this.sendLogin}>
              Onayla
            </button>
          </div>
          <div className="control">
            <button className="button is-text">İptal</button>
          </div>
        </div>
      </div>
    );
  }
}
