import * as React from "react";
import SimpleReactValidator from "simple-react-validator";
export interface Props {
  isLoading: boolean;
  createUser: Function;
}
export interface State {}

export default class CreateUser extends React.Component<Props, State> {
  constructor(props) {
    super(props);
    this.validator = new SimpleReactValidator();
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
    if (this.validator.allValid()) {
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
    } else {
      this.validator.showMessages();
      // rerender to show messages for the first time
      this.forceUpdate();
    }
  };

  render() {
    if (this.props.isLoading) {
      return <div>Loading...</div>;
    }
    return (
      <div className="container">
        <a href="/">Anasayfaya dön</a>
        <div className="field">
          <label className="label">Kullanıcı Adı</label>
          <div className="control">
            <input
              className="input"
              type="text"
              name="username"
              placeholder="Kullanıcı Adı"
              id="username"
              value={this.state.username}
              onChange={this.handleChange}
            />
            {this.validator.message(
              "username",
              this.state.username,
              "required",
              false,
              {
                required: "Lütfen kullanıcı adınızı giriniz. ",
                default: "Invalid."
              }
            )}
          </div>
        </div>
        <div className="field">
          <label className="label">Şifre</label>
          <div className="control">
            <input
              className="input"
              type="text"
              name="password"
              placeholder="Şifre"
              id="password"
              value={this.state.password}
              onChange={this.handleChange}
            />
            {this.validator.message(
              "password",
              this.state.password,
              "required",
              false,
              {
                required: "Lütfen şifrenizi giriniz. ",
                default: "Invalid."
              }
            )}
          </div>
        </div>
        <div className="field">
          <label className="label">Email Adres</label>
          <div className="control">
            <input
              id="emailAddress"
              className="input"
              type="text"
              name="emailAddres"
              placeholder="Email Adres"
              value={this.state.emailAddress}
              onChange={this.handleChange}
            />
            {this.validator.message(
              "email",
              this.state.emailAddress,
              "required|email",
              false,
              {
                required: "Lütfen email adresi giriniz. ",
                default: "Invalid."
              }
            )}
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
              name="firstName"
              value={this.state.firstName}
              onChange={this.handleChange}
            />
            {this.validator.message(
              "Ad",
              this.state.firstName,
              "required",
              false,
              {
                required: "Lütfen adınızı giriniz. ",
                default: "Invalid."
              }
            )}
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
              name="lastName"
              value={this.state.lastName}
              onChange={this.handleChange}
            />
            {this.validator.message(
              "Soyad",
              this.state.lastName,
              "required|min:2",
              false,
              {
                required: "Lütfen soyadınızı giriniz.",
                default: "Invalid."
              }
            )}
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
            {this.validator.message(
              "Doğum tarihi",
              this.state.birthDate,
              "required|min:2",
              false,
              {
                required: "Lütfen doğum tarihinizi seçiniz. ",
                default: "Invalid."
              }
            )}
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
              {this.validator.message(
                "Ülke",
                this.state.country,
                "required",
                false,
                { required: "Lütfen ülke seçiniz. ", default: "Invalid." }
              )}
            </div>
          </div>
        </div>
        <br />
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
              {this.validator.message(
                "Şehir",
                this.state.city,
                "required",
                false,
                { required: "Lütfen şehir seçiniz. ", default: "Invalid." }
              )}
            </div>
          </div>
        </div>
        <br />
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
              {this.validator.message(
                "İlçe",
                this.state.district,
                "required",
                false,
                { required: "Lütfen ilçe seçiniz. ", default: "Invalid." }
              )}
            </div>
          </div>
        </div>
        <br />
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
