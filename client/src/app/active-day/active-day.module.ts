import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActiveDayCardComponent } from './active-day-card/active-day-card.component';
import { ActiveDayHomeComponent } from './active-day-home/active-day-home.component';
import { ActiveDayPageComponent } from './active-day-page/active-day-page.component';
import { MatCardModule } from '@angular/material/card';
import { RatingModule } from '../rating/rating.module';
import { CommentsModule } from '../comments/comments.module';
import { MatButtonModule } from '@angular/material/button';
import { ActiveDayRoutingModule } from './active-day-routing.module';

@NgModule({
  declarations: [
    ActiveDayCardComponent,
    ActiveDayHomeComponent,
    ActiveDayPageComponent,
  ],
  imports: [
    CommonModule,
    MatCardModule,
    RatingModule,
    CommentsModule,
    MatButtonModule,
    RatingModule,
  ],
  exports: [ActiveDayRoutingModule],
})
export class ActiveDayModule {}
