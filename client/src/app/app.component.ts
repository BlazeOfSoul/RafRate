import { Component } from '@angular/core';
import {User} from './models/user';
import {UserService} from "./services/user.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'RafRate';

  users: User[] = [];

  constructor(private  userService: UserService) {}

  ngOnInit() : void {
    this.userService
      .getUsers()
      .subscribe((result: User[]) => (this.users = result));
  }
}
