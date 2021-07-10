import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RemoveOfficeAssignmentComponent } from './remove-office-assignment.component';

describe('RemoveOfficeAssignmentComponent', () => {
  let component: RemoveOfficeAssignmentComponent;
  let fixture: ComponentFixture<RemoveOfficeAssignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RemoveOfficeAssignmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RemoveOfficeAssignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
