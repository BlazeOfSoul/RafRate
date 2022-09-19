import { MatCardModule } from '@angular/material/card';
import { CommentsModule } from './../comments/comments.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TeachersHomeComponent } from './teachers-home/teachers-home.component';
import { TeacherCardComponent } from './teacher-card/teacher-card.component';
import { TeacherPersonPageComponent } from './teacher-person-page/teacher-person-page.component';
import { TeachersRoutingModule } from './teachers-routing.module';



@NgModule({
  declarations: [
    TeachersHomeComponent,
    TeacherCardComponent,
    TeacherPersonPageComponent
  ],
  imports: [
    CommonModule,
    TeachersRoutingModule,
    CommentsModule,
    MatCardModule
  ],
  exports: [
    TeachersHomeComponent
  ]
})
export class TeachersModule { }
