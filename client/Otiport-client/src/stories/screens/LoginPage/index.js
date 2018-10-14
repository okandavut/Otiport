import * as React from "react";
import SimpleReactValidator from "simple-react-validator";

export interface Props {
  isLoading: boolean;
  login: Function;
}
export interface State {
  count: number;
  emailAddress: string;
  password: string;
}

export default class LoginPage extends React.Component<Props, State> {
  constructor(props) {
    super(props);
    this.validator = new SimpleReactValidator();
    this.state = {
      emailAddress: "",
      password: "",
      warning: "",
      isEmailValid: null
    };
  }
  sendLogin = () => {
    if (this.validator.allValid()) {
      this.props.login(this.state.emailAddress, this.state.password);
    } else {
      this.validator.showMessages();
      // rerender to show messages for the first time
      this.forceUpdate();
    }
  };

  handleChange = event => {
    this.setState({
      [event.target.id]: event.target.value
    });
  };
  render() {
    if (this.props.isLoading) {
      return (
        <div>
          <span>Loading....</span>
        </div>
      );
    }
    return (
      <div className="container">
        <a href="/">Anasayfaya dön</a>
        <section className="hero">
          <div className="hero-body">
            <div className="container">
              <h1 className="title">Otiport</h1>
              <h2 className="subtitle">Login</h2>
            </div>
          </div>
        </section>
        <div className="columns level-item level-right">
          <div className="column is-one-third">
            <div className="field">
              <label className="label">Email</label>
              <div className="control">
                <input
                  type="email"
                  id="emailAddress"
                  className="input"
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
                    default: "Email adresi formatı düzgün olmalıdır."
                  }
                )}
              </div>
            </div>

            <div className="field">
              <label className="label">Password</label>
              <div className="control">
                <input
                  type="password"
                  id="password"
                  className="input"
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
            <br />
            <div className="field is-grouped">
              <div className="control">
                <button onClick={this.sendLogin} className="button is-link">
                  {" "}
                  Login{" "}
                </button>
              </div>
              <div className="control">
                <button className="button is-link">Cancel</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}
