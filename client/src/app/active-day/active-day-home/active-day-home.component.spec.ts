import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActiveDayHomeComponent } from './active-day-home.component';

describe('ActiveDayHomeComponent', () => {
  let component: ActiveDayHomeComponent;
  let fixture: ComponentFixture<ActiveDayHomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ActiveDayHomeComponent],
    }).compileComponents();

    fixture = TestBed.createComponent(ActiveDayHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
