import { MatIconModule } from '@angular/material/icon';
import { SigninFormComponent } from './signin-form/signin-form.component';
import { MatCardModule } from '@angular/material/card';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import { SignupFormComponent } from './signup-form/signup-form.component';
import { UserPageComponent } from './user-page/user-page.component';
import { MatInputModule} from "@angular/material/input";
import { MatButtonModule} from "@angular/material/button";
import {UserRoutingModule} from "./user-routing.module";

@NgModule({
  declarations: [
    SigninFormComponent,
    SignupFormComponent,
    UserPageComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatFormFieldModule,
    MatIconModule,
    MatInputModule,
    MatButtonModule
  ],
  exports: [
    UserRoutingModule
  ]
})
export class UserModule { }
