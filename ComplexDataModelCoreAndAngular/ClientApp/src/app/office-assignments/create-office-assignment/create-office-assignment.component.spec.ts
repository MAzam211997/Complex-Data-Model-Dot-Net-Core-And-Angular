import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateOfficeAssignmentComponent } from './create-office-assignment.component';

describe('CreateOfficeAssignmentComponent', () => {
  let component: CreateOfficeAssignmentComponent;
  let fixture: ComponentFixture<CreateOfficeAssignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateOfficeAssignmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateOfficeAssignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
