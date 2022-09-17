import { CommentsHomeComponent } from './comments/comments-home/comments-home.component';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from "@angular/common/http";
import { HeaderComponent } from './components/layout/header/header.component';
import { FooterComponent } from './components/layout/footer/footer.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule} from "@angular/material/toolbar";
import { MatIconModule} from "@angular/material/icon";
import { MatButtonModule} from "@angular/material/button";
import { ActiveDayHomeComponent } from './components/active-day-home/active-day-home.component';
import { HomeComponent } from './components/home/home.component';
import { SigninFormComponent } from './user/signin-form/signin-form.component';
import { UserInfoComponent } from './user/user-info/user-info.component';
import { SignupFormComponent } from './user/signup-form/signup-form.component';
import { MatInputModule } from '@angular/material/input';
import { MatCardModule } from '@angular/material/card';
import { ActiveDayCardComponent } from './components/active-day-card/active-day-card.component';
import { ActiveDayPageComponent } from './components/active-day-page/active-day-page.component';
import { CommentsModule } from './comments/comments.module';
import { RatingModule } from './rating/rating.module';
import { TeachersModule } from './teachers/teachers.module';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    ActiveDayHomeComponent,
    HomeComponent,
    SigninFormComponent,
    UserInfoComponent,
    SignupFormComponent,
    ActiveDayCardComponent,
    ActiveDayPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatInputModule,
    MatCardModule,
    CommentsModule,
    RatingModule,
    TeachersModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
