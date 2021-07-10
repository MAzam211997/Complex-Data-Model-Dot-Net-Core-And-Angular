import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateDepartmentComponent } from './create-department/create-department.component';
import { ViewDepartmentsComponent } from './view-departments/view-departments.component';
import { UpdateDepartmentComponent } from './update-department/update-department.component';
import { RemoveDepartmentComponent } from './remove-department/remove-department.component';



@NgModule({
  declarations: [
    CreateDepartmentComponent,
    ViewDepartmentsComponent,
    UpdateDepartmentComponent,
    RemoveDepartmentComponent
  ],
  imports: [
    CommonModule
  ]
})
export class DepartmentsModule { }
