import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TeacherHomeComponent } from './teacher-home.component';

describe('TeachersHomeComponent', () => {
  let component: TeacherHomeComponent;
  let fixture: ComponentFixture<TeacherHomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TeacherHomeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TeacherHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
