import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateCourseAssignmentComponent } from './update-course-assignment.component';

describe('UpdateCourseAssignmentComponent', () => {
  let component: UpdateCourseAssignmentComponent;
  let fixture: ComponentFixture<UpdateCourseAssignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateCourseAssignmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateCourseAssignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
