import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DisciplinesHomeComponent } from "./disciplines-home/disciplines-home.component";



@NgModule({
  declarations: [
    DisciplinesHomeComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    DisciplinesHomeComponent
  ]
})
export class DisciplinesModule { }
