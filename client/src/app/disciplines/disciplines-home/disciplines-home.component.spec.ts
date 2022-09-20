import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisciplinesHomeComponent } from './disciplines-home.component';

describe('DisciplinesHomeComponent', () => {
  let component: DisciplinesHomeComponent;
  let fixture: ComponentFixture<DisciplinesHomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DisciplinesHomeComponent],
    }).compileComponents();

    fixture = TestBed.createComponent(DisciplinesHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
