import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MainModule } from './main/main.module';
import { ActiveDayModule } from './active-day/active-day.module';
import { TeacherModule } from './teacher/teacher.module';

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MainModule,
    ActiveDayModule,
    TeacherModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
