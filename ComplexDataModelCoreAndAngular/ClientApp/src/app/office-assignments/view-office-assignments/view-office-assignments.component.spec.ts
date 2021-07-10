import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewOfficeAssignmentsComponent } from './view-office-assignments.component';

describe('ViewOfficeAssignmentsComponent', () => {
  let component: ViewOfficeAssignmentsComponent;
  let fixture: ComponentFixture<ViewOfficeAssignmentsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewOfficeAssignmentsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewOfficeAssignmentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
