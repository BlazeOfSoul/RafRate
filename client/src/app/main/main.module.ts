import { MatToolbarModule } from '@angular/material/toolbar';
import { FooterComponent } from './layout/footer/footer.component';
import { HeaderComponent } from './layout/header/header.component';
import { HomeComponent } from './home/home.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActiveDayRoutingModule } from "../active-day/active-day-routing.module";
import { TeacherRoutingModule } from "../teacher/teacher-routing.module";
import { UserRoutingModule } from "../user/user-routing.module";
import { ActiveDayModule } from "../active-day/active-day.module";
import { TeacherModule } from "../teacher/teacher.module";
import { UserModule } from "../user/user.module";
import { MainRoutingModule } from "./main-routing.module";


@NgModule({
  declarations: [
    HomeComponent,
    HeaderComponent,
    FooterComponent,
  ],
  imports: [
    CommonModule,
    MatToolbarModule,
    ActiveDayRoutingModule,
    ActiveDayModule,
    TeacherRoutingModule,
    TeacherModule,
    UserRoutingModule,
    UserModule
  ],
  exports: [
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    MainRoutingModule
  ]
})
export class MainModule { }
