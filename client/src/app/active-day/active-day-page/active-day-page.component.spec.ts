import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActiveDayPageComponent } from './active-day-page.component';

describe('ActiveDayPageComponent', () => {
  let component: ActiveDayPageComponent;
  let fixture: ComponentFixture<ActiveDayPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ActiveDayPageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ActiveDayPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
