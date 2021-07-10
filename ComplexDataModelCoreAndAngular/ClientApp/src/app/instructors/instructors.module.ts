import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateInstructorComponent } from './create-instructor/create-instructor.component';
import { ViewInstructorsComponent } from './view-instructors/view-instructors.component';
import { UpdateInstructorComponent } from './update-instructor/update-instructor.component';
import { RemoveInstructorComponent } from './remove-instructor/remove-instructor.component';



@NgModule({
  declarations: [
    CreateInstructorComponent,
    ViewInstructorsComponent,
    UpdateInstructorComponent,
    RemoveInstructorComponent
  ],
  imports: [
    CommonModule
  ]
})
export class InstructorsModule { }
