import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateOfficeAssignmentComponent } from './create-office-assignment/create-office-assignment.component';
import { ViewOfficeAssignmentsComponent } from './view-office-assignments/view-office-assignments.component';
import { UpdateOfficeAssignmentComponent } from './update-office-assignment/update-office-assignment.component';
import { RemoveOfficeAssignmentComponent } from './remove-office-assignment/remove-office-assignment.component';



@NgModule({
  declarations: [
    CreateOfficeAssignmentComponent,
    ViewOfficeAssignmentsComponent,
    UpdateOfficeAssignmentComponent,
    RemoveOfficeAssignmentComponent
  ],
  imports: [
    CommonModule
  ]
})
export class OfficeAssignmentsModule { }
