import { Injectable } from '@angular/core';
import { User } from '../models/user';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {environment} from "../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private url = "Authentication/Users";
  constructor(private http : HttpClient) { }

  public  getUsers() : Observable<User[]> {
    return this.http.get<User[]>(`${environment.apiUrl}/${this.url}`);
  }
}
