import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ActiveDayHomeComponent } from "./active-day-home/active-day-home.component";
import { ActiveDayPageComponent } from "./active-day-page/active-day-page.component";

const routes: Routes = [
  {
    path:'active-day-list',
    component: ActiveDayHomeComponent
  },
  {
    path:'active-day-page',
    component: ActiveDayPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class ActiveDayRoutingModule { }
