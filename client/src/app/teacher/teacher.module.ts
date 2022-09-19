import { MatCardModule } from '@angular/material/card';
import { CommentsModule } from './../comments/comments.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TeacherHomeComponent } from './teacher-home/teacher-home.component';
import { TeacherCardComponent } from './teacher-card/teacher-card.component';
import { TeacherPersonPageComponent } from './teacher-person-page/teacher-person-page.component';
import { TeacherRoutingModule } from './teacher-routing.module';



@NgModule({
  declarations: [
    TeacherHomeComponent,
    TeacherCardComponent,
    TeacherPersonPageComponent
  ],
  imports: [
    CommonModule,
    TeacherRoutingModule,
    CommentsModule,
    MatCardModule
  ],
  exports: [
    TeacherHomeComponent
  ]
})
export class TeacherModule { }
