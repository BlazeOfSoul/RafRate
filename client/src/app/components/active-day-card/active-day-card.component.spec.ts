import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActiveDayCardComponent } from './active-day-card.component';

describe('ActiveDayCardComponent', () => {
  let component: ActiveDayCardComponent;
  let fixture: ComponentFixture<ActiveDayCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ActiveDayCardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ActiveDayCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
