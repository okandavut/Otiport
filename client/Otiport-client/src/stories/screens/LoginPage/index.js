import * as React from "react";

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
    this.state = {
      emailAddress: "",
      password: "",
      warning: "",
      isEmailValid: null
    };
  }
  sendLogin = () => {
    if (this.state.isEmailValid)
      this.props.login(this.state.emailAddress, this.state.password);
    else alert("Lütfen email adresini kontrol ediniz.");
  };
  isValidEmailAddress(address) {
    let re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    if (re.test(this.state.emailAddress)) {
      this.state.isEmailValid = true;
      return (this.state.warning = "");
    } else {
      this.state.isEmailValid = false;
      return (this.state.warning =
        "Email adresi hatalı lütfen kontrol ediniz.");
    }
  }
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
       <section class="hero">
            <div class="hero-body">
              <div class="container">
                <h1 class="title">Otiport</h1>
                <h2 class="subtitle">Login</h2>
              </div>
            </div>
          </section>
        <div className="columns level-item ">
         
          <div class="column is-half ">
            <div className="field">
              <label className="label">Email</label>
              <div className="control has-icons-left has-icons-right">
                <input
                  type="email"
                  id="emailAddress"
                  className="input"
                  value={this.state.emailAddress}
                  onChange={this.handleChange}
                  onBlur={() =>
                    this.setState({
                      emailIsValid: this.isValidEmailAddress(this.state.email)
                    })
                  }
                />

                <span className="icon is-small is-left">
                  <i className="fas fa-envelope" />
                </span>
                <span className="icon is-small is-right">
                  <i className="fas fa-exclamation-triangle" />
                </span>
              </div>
              <p className="help is-danger">{this.state.warning}</p>
            </div>

            <div classNameName="field">
              <label classNameName="label">Password</label>
              <div className="control has-icons-left has-icons-right">
                <input
                  type="password"
                  id="password"
                  className="input"
                  value={this.state.password}
                  onChange={this.handleChange}
                />

                <span classNameName="icon is-small is-left">
                  <i className="fas fa-envelope" />
                </span>
                <span className="icon is-small is-right">
                  <i className="fas fa-exclamation-triangle" />
                </span>
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
