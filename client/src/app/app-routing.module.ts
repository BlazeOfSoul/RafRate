import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ActiveDayHomeComponent } from "./components/active-day-home/active-day-home.component";
import {HomeComponent} from "./components/home/home.component";
import {SigninFormComponent} from "./user/signin-form/signin-form.component";
import {SignupFormComponent} from "./user/signup-form/signup-form.component";
import { ActiveDayPageComponent } from './components/active-day-page/active-day-page.component';
import { TeachersHomeComponent } from './teachers/teachers-home/teachers-home.component';

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
    path:'ActiveDayList',
    component: ActiveDayHomeComponent
  },
  {
    path:'ActiveDayPage',
    component: ActiveDayPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
