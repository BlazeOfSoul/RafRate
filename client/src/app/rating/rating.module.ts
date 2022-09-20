import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RatingHomeComponent } from './rating-home/rating-home.component';

@NgModule({
  declarations: [RatingHomeComponent],
  imports: [CommonModule],
  exports: [RatingHomeComponent],
})
export class RatingModule {}
