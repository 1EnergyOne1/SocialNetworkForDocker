import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { AuthorizationComponent } from "./user-info/authorization.component";

@NgModule({
    imports: [
    BrowserModule,
    FormsModule // Добавляем FormsModule в массив imports
    ,
],
    providers: []
  })
export class AppModule { }
