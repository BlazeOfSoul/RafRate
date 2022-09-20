import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TeacherPersonPageComponent } from './teacher-person-page/teacher-person-page.component';
import { TeacherHomeComponent } from './teacher-home/teacher-home.component';

const routes: Routes = [
  {
    path: 'teacher-list',
    component: TeacherHomeComponent,
  },
  {
    path: 'teacher-page',
    component: TeacherPersonPageComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class TeacherRoutingModule {}
