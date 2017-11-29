import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { TableComponent } from './table/table.component';
import { ItemDetailComponent } from './item-detail/item-detail.component';
import { APIService } from './services/api.service';
import { BaseRestService } from './services/baseRest.service';
import { Http } from '@angular/http/';
import { HttpModule } from '@angular/http/';

@NgModule({
  declarations: [
    AppComponent,
    TableComponent,
    ItemDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    HttpModule,
    FormsModule
  ],
  providers: [
    APIService,
    BaseRestService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
