import { Component } from "@angular/core";
import { User } from "../../models/user";
import { FormsModule } from "@angular/forms";
import { CommonModule } from "@angular/common";
import { HttpClient, HttpClientModule, HttpHandler } from "@angular/common/http";

@Component({
  selector: 'authorization',
  standalone: true,
  templateUrl: './authorization.component.html',
  styleUrls: ['./authorization.component.scss'],
  imports: [FormsModule, CommonModule, HttpClientModule],
  providers: [User]
})
export class AuthorizationComponent {

  public login: string = "";
  public password: string = "";
  user: User = new User();
  Islogged: boolean = false;

  constructor(private _http: HttpClient) { }

  async getUser() {
    /* await this._mongoService.getUser("Antony").then(
      result => {
        let s = result;
      },
      error => {
        let r = error;
      }
    );  */ 

    await this.getUserr(this.login, this.password).then(
      result => {
        this.user = result as User;
        let s = result;
        this.Islogged = true;
      },
      error => {

      }
    );
  }

  async getUserr(login: string, password: string) {
    return this._http.get(`http://localhost:8080/api/users/GetUser?login=${login}&password=${password}`).toPromise();
}
}