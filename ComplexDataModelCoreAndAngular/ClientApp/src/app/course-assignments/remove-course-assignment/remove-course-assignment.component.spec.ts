import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RemoveCourseAssignmentComponent } from './remove-course-assignment.component';

describe('RemoveCourseAssignmentComponent', () => {
  let component: RemoveCourseAssignmentComponent;
  let fixture: ComponentFixture<RemoveCourseAssignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RemoveCourseAssignmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RemoveCourseAssignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
