import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { TeacherPersonPageComponent } from "./teacher-person-page/teacher-person-page.component";
import { TeachersHomeComponent } from "./teachers-home/teachers-home.component";

const routes: Routes = [
  {
    path:'Teacher',
    component: TeachersHomeComponent
  },
  {
    path:'TeacherPage',
    component: TeacherPersonPageComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class TeachersRoutingModule { }
