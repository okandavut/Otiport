import * as React from "react";

export interface Props {
  title: string;
  isLoading: boolean;
  login: Function;
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
    if (this.props.isLoading) {
      return (
        <div>
          <span> Loading.... </span>
        </div>
      );
    }
    return (
      <div>
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
          <div class="container">
            <a class="navbar-brand" href="#">
              OTIPORT
            </a>
            <button
              class="navbar-toggler"
              type="button"
              data-toggle="collapse"
              data-target="#navbarResponsive"
              aria-controls="navbarResponsive"
              aria-expanded="false"
              aria-label="Toggle navigation"
            >
              <span class="navbar-toggler-icon" />
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
              <ul class="navbar-nav ml-auto">
                <li class="nav-item active">
                  <a class="nav-link" href="/Login">
                    Portala Gir
                    <span class="sr-only">(current)</span>
                  </a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="/createUser">
                    Kayıt Ol
                  </a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="#">
                    Hakkımızda
                  </a>
                </li>
              </ul>
            </div>
          </div>
        </nav>

        <header class="business-header">
          <div class="container">
            <div class="row">
              <div class="col-lg-12">
                <h1 class="display-5 text-center text-white mt-4">
                <br/><br/><br/><br/>
                  OTIZM PORTAL SITESI
                </h1>
              </div>
            </div>
          </div>
        </header>

        <div class="container">
          <div class="row">
            <div class="col-sm-12">
              <h2 class="mt-4">Otiport Nedir?</h2>
              <p>
                Otiport, otizmli bireylerin ailelerine yönelik hazırlanmış bir portaldır.
                Otiport, otizmli bireylerin ailelerine yönelik hazırlanmış bir portaldır.
                Otiport, otizmli bireylerin ailelerine yönelik hazırlanmış bir portaldır.
                Otiport, otizmli bireylerin ailelerine yönelik hazırlanmış bir portaldır.
                Otiport, otizmli bireylerin ailelerine yönelik hazırlanmış bir portaldır.
              </p>
              <p>
              Otiport, otizmli bireylerin ailelerine yönelik hazırlanmış bir portaldır.
              Otiport, otizmli bireylerin ailelerine yönelik hazırlanmış bir portaldır.
              Otiport, otizmli bireylerin ailelerine yönelik hazırlanmış bir portaldır.
              Otiport, otizmli bireylerin ailelerine yönelik hazırlanmış bir portaldır.
              Otiport, otizmli bireylerin ailelerine yönelik hazırlanmış bir portaldır.
              </p>
              <p>
                <a class="btn btn-primary btn-lg" href="#">
                  Daha Fazla Bilgi &raquo;
                </a>
              </p>
            </div>
          </div>

          <div class="row">
            <div class="col-sm-4 my-4">
              <div class="card">
                <img
                  class="card-img-top"
                  src="http://placehold.it/300x200"
                  alt=""
                />
                <div class="card-body">
                  <h4 class="card-title">Portalın Faydaları</h4>
                  <p class="card-text">
                    Portal nasıl bir fayda saglar?Portal nasıl bir fayda saglar?
                    Portal nasıl bir fayda saglar?
                    Portal nasıl bir fayda saglar?
                  </p>
                </div>
                <div class="card-footer">
                  <a href="#" class="btn btn-primary">
                   Daha fazla bilgi
                  </a>
                </div>
              </div>
            </div>
              <div class="col-sm-4 my-4">
              <div class="card">
                <img
                  class="card-img-top"
                  src="http://placehold.it/300x200"
                  alt=""
                />
                <div class="card-body">
                  <h4 class="card-title">Portalın Faydaları</h4>
                  <p class="card-text">
                    Portal nasıl bir fayda saglar?Portal nasıl bir fayda saglar?
                    Portal nasıl bir fayda saglar?
                    Portal nasıl bir fayda saglar?
                  </p>
                </div>
                <div class="card-footer">
                  <a href="#" class="btn btn-primary">
                   Daha fazla bilgi
                  </a>
                </div>
              </div>
            </div>
            <div class="col-sm-4 my-4">
              <div class="card">
                <img
                  class="card-img-top"
                  src="http://placehold.it/300x200"
                  alt=""
                />
                <div class="card-body">
                  <h4 class="card-title">Portalın Faydaları</h4>
                  <p class="card-text">
                    Portal nasıl bir fayda saglar?Portal nasıl bir fayda saglar?
                    Portal nasıl bir fayda saglar?
                    Portal nasıl bir fayda saglar?
                  </p>
                </div>
                <div class="card-footer">
                  <a href="#" class="btn btn-primary">
                   Daha fazla bilgi
                  </a>
                </div>
              </div>
            </div>
          </div>
        </div>

        <footer class="py-5 bg-dark">
          <div class="container">
            <p class="m-0 text-center text-white">
              Copyright &copy; OTIPORT - 2018
            </p>
          </div>
        </footer>
      </div>
    );
  }
}
