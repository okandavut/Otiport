import * as React from "react";

export interface Props {
  isLoading: boolean;
  login: Function;

}
export interface State {
  count: number;
  emailAddress: string;
  password : string;
}

export default class LoginPage extends React.Component<Props, State> {

  constructor(props) {
    super(props);
    this.state = {
      emailAddress: "",
      password: "",
      warning :"",
      isEmailValid : null    };
  }
  sendLogin= () => {
    if(this.state.isEmailValid)
      this.props.login(this.state.emailAddress,this.state.password)
     else 
      alert("Lütfen email adresini kontrol ediniz.");
  }
  isValidEmailAddress(address) {
    let re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    if ( re.test(this.state.emailAddress) ) {
      this.state.isEmailValid = true;
      return this.state.warning = "";
    }
    else {
      this.state.isEmailValid = false;
      return this.state.warning = "Email adresi hatalı lütfen kontrol ediniz.";
    }
  }
  handleChange = event => {
    this.setState({
      [event.target.id]: event.target.value
    });
  }
  render() {
    if (this.props.isLoading) {
      return (
        <div>
          <span>Loading....</span>
        </div>
      );
    }
    return (
      <div>
      <p>{this.state.warning}</p>
        <input  
          type="email" 
          id="emailAddress"   
          value={this.state.emailAddress}
          onChange={this.handleChange}
          onBlur={() => this.setState({  
            emailIsValid: this.isValidEmailAddress(this.state.email)  
          })}
        />
        
        <input 
          type="password" 
          id="password" 
          value={this.state.password} 
          onChange={this.handleChange}
        />
        <button onClick={this.sendLogin}> Login </button>
      </div>
    );
  }
}
