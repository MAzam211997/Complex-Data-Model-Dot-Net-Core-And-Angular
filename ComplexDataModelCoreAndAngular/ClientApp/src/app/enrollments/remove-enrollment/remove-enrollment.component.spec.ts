import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RemoveEnrollmentComponent } from './remove-enrollment.component';

describe('RemoveEnrollmentComponent', () => {
  let component: RemoveEnrollmentComponent;
  let fixture: ComponentFixture<RemoveEnrollmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RemoveEnrollmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RemoveEnrollmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
