import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewCourseAssignmentsComponent } from './view-course-assignments.component';

describe('ViewCourseAssignmentsComponent', () => {
  let component: ViewCourseAssignmentsComponent;
  let fixture: ComponentFixture<ViewCourseAssignmentsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewCourseAssignmentsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewCourseAssignmentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
