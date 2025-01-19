import { Component } from '@angular/core';
import { AuthorizationComponent } from "./user-info/authorization.component";

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  imports: [AuthorizationComponent],
})
export class AppComponent {
  title = 'social-network-front';
}
