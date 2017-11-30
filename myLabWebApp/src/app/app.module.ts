import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ItemDetailComponent } from './items/item-detail.component';
import { APIService } from './services/api.service';
import { BaseRestService } from './services/baseRest.service';
import { Http } from '@angular/http/';
import { HttpModule } from '@angular/http/';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { CategoryComponent } from './categories/category.component';
import { CategoriesComponent } from './categories/categories-overview.component';
import { ItemsOverviewComponent } from './items/items-overview.component';
import { DataTableModule, SharedModule } from 'primeng/primeng';

@NgModule({
  declarations: [
    AppComponent,
    TableComponent,
    ItemsOverviewComponent,
    ItemDetailComponent,
    CategoryComponent,
    CategoriesComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    HttpModule,
    FormsModule,
    DataTableModule,
    SharedModule,
    NgbModule.forRoot()
  ],
  providers: [
    APIService,
    BaseRestService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
