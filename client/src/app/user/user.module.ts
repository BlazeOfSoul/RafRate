import { MatIconModule } from '@angular/material/icon';
import { SigninFormComponent } from './signin-form/signin-form.component';
import { MatCardModule } from '@angular/material/card';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import { SignupFormComponent } from './signup-form/signup-form.component';
import { UserInfoComponent } from './user-info/user-info.component';

@NgModule({
  declarations: [
    SigninFormComponent,
    SignupFormComponent,
    UserInfoComponent,
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatFormFieldModule,
    MatIconModule
  ]
})
export class UserModule { }
