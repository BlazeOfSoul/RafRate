import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ActiveDayComponent } from "./components/active-day/active-day.component";
import {HomeComponent} from "./components/home/home.component";
import {SigninFormComponent} from "./user/signin-form/signin-form.component";
import {SignupFormComponent} from "./user/signup-form/signup-form.component";
import {TeachersComponent} from "./components/teachers/teachers.component";

const routes: Routes = [
  {
    path:'',
    component: HomeComponent
  },
  {
    path:'SignIn',
    component: SigninFormComponent
  },
  {
    path:'SignUp',
    component: SignupFormComponent
  },
  {
    path:'Teacher',
    component: TeachersComponent
  },
  {
    path:'ActiveDay',
    component: ActiveDayComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
