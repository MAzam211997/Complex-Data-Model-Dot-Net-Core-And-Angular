import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateOfficeAssignmentComponent } from './update-office-assignment.component';

describe('UpdateOfficeAssignmentComponent', () => {
  let component: UpdateOfficeAssignmentComponent;
  let fixture: ComponentFixture<UpdateOfficeAssignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateOfficeAssignmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateOfficeAssignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
