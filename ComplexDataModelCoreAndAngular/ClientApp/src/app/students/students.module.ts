import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateStudentComponent } from './create-student/create-student.component';
import { ViewStudentsComponent } from './view-students/view-students.component';
import { UpdateStudentComponent } from './update-student/update-student.component';
import { RemoveStudentComponent } from './remove-student/remove-student.component';



@NgModule({
  declarations: [
    CreateStudentComponent,
    ViewStudentsComponent,
    UpdateStudentComponent,
    RemoveStudentComponent
  ],
  imports: [
    CommonModule
  ]
})
export class StudentsModule { }
