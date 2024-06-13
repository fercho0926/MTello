import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { ChecksComponent } from './checks/checks.component';
import { FooterComponent } from './footer/footer.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { NavbarComponent } from './navbar/navbar.component';
import { ReportingComponent } from './reporting/reporting.component';
import { ReportingDetailsComponent } from './reporting/reporting-details/reporting-details.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { MaterialModule } from '../material/material.module';



@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    MaterialModule

  ],
  declarations: [
    FooterComponent,
    NavbarComponent,
    SidebarComponent,
    ChecksComponent,
    ReportingComponent,
    ReportingDetailsComponent
  ],
  exports: [
    FooterComponent,
    NavbarComponent,
    SidebarComponent
  ]
})
export class ComponentsModule { }
