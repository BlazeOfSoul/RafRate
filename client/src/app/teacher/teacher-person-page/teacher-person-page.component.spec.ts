import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TeacherPersonPageComponent } from './teacher-person-page.component';

describe('TeacherPersonPageComponent', () => {
  let component: TeacherPersonPageComponent;
  let fixture: ComponentFixture<TeacherPersonPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TeacherPersonPageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TeacherPersonPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
