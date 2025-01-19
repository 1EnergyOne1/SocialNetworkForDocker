import { NgModule } from '@angular/core';
import { AuthorizationComponent } from './authorization.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import {MatButtonModule} from '@angular/material/button';
import {MatInputModule} from '@angular/material/input';
import {MatTabsModule} from '@angular/material/tabs';

@NgModule({
  imports: [
    HttpClientModule,
    FormsModule,
    CommonModule,
    MatButtonModule,
    MatInputModule,
    MatTabsModule
  ],
})
export class AuthorizationModule { }
