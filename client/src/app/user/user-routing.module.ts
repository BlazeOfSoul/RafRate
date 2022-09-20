import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignupFormComponent } from './signup-form/signup-form.component';
import { SigninFormComponent } from './signin-form/signin-form.component';
import { UserPageComponent } from './user-page/user-page.component';

const routes: Routes = [
  {
    path: 'sign-in',
    component: SignupFormComponent,
  },
  {
    path: 'sign-up',
    component: SigninFormComponent,
  },
  {
    path: 'user-page',
    component: UserPageComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class UserRoutingModule {}
