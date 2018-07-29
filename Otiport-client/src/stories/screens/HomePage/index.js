import * as React from "react";

export interface Props {
  title: string;
}
export interface State {
  count: number;
}

export default class HomePage extends React.Component<Props, State> {
  constructor(props) {
    super(props);
    this.state = {
      count: 0
    };
  }

  render() {
    return <div> HELLO HOMEPAGE 
      <br/>HOME PAGE - COMPONENTI
    </div>;
  }
}
