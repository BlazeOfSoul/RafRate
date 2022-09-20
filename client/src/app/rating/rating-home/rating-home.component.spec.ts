import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RatingHomeComponent } from './rating-home.component';

describe('RatingHomeComponent', () => {
  let component: RatingHomeComponent;
  let fixture: ComponentFixture<RatingHomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RatingHomeComponent],
    }).compileComponents();

    fixture = TestBed.createComponent(RatingHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
