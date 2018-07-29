import React, { Component } from "react";
import logo from "./logo.svg";
import "./App.css";
import HomePageContainer from "../src/containers/HomePageContainer";

class App extends Component {
  render() {
    return (
      <div className="App">
        <HomePageContainer />
      </div>
    );
  }
}

export default App;
