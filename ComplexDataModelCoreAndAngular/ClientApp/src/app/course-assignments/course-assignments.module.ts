import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateCourseAssignmentComponent } from './create-course-assignment/create-course-assignment.component';
import { ViewCourseAssignmentsComponent } from './view-course-assignments/view-course-assignments.component';
import { UpdateCourseAssignmentComponent } from './update-course-assignment/update-course-assignment.component';
import { RemoveCourseAssignmentComponent } from './remove-course-assignment/remove-course-assignment.component';



@NgModule({
  declarations: [
    CreateCourseAssignmentComponent,
    ViewCourseAssignmentsComponent,
    UpdateCourseAssignmentComponent,
    RemoveCourseAssignmentComponent
  ],
  imports: [
    CommonModule
  ]
})
export class CourseAssignmentsModule { }
