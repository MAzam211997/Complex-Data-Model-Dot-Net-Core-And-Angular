import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateCourseComponent } from './create-course/create-course.component';
import { ViewCoursesComponent } from './view-courses/view-courses.component';
import { UpdateCourseComponent } from './update-course/update-course.component';
import { RemoveCourseComponent } from './remove-course/remove-course.component';



@NgModule({
  declarations: [
    CreateCourseComponent,
    ViewCoursesComponent,
    UpdateCourseComponent,
    RemoveCourseComponent
  ],
  imports: [
    CommonModule
  ]
})
export class CoursesModule { }
