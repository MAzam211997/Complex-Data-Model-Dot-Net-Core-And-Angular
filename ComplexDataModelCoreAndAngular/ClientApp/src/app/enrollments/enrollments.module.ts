import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateEnrollmentComponent } from './create-enrollment/create-enrollment.component';
import { ViewEnrollmentsComponent } from './view-enrollments/view-enrollments.component';
import { UpdateEnrollmentComponent } from './update-enrollment/update-enrollment.component';
import { RemoveEnrollmentComponent } from './remove-enrollment/remove-enrollment.component';



@NgModule({
  declarations: [
    CreateEnrollmentComponent,
    ViewEnrollmentsComponent,
    UpdateEnrollmentComponent,
    RemoveEnrollmentComponent
  ],
  imports: [
    CommonModule
  ]
})
export class EnrollmentsModule { }
