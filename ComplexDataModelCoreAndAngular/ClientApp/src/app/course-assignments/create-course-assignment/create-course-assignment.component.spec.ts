import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateCourseAssignmentComponent } from './create-course-assignment.component';

describe('CreateCourseAssignmentComponent', () => {
  let component: CreateCourseAssignmentComponent;
  let fixture: ComponentFixture<CreateCourseAssignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateCourseAssignmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateCourseAssignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
