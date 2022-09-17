import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CommentsHomeComponent } from './comments-home/comments-home.component';



@NgModule({
  declarations: [
    CommentsHomeComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    CommentsHomeComponent
  ]
})
export class CommentsModule { }
