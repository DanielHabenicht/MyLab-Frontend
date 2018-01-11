//Angular
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { Http } from '@angular/http/';
import { HttpModule } from '@angular/http/';

//Custom
import { BaseRestService } from './services/baseRest.service';
import { APIService } from './services/api.service';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ItemDetailComponent } from './items/item-detail.component';
import { ItemsOverviewComponent } from './items/items-overview.component';
import { CategoryComponent } from './categories/category.component';
import { CategoriesComponent } from './categories/categories-overview.component';

//Everything from Prime NG
import { DataTableModule, SharedModule } from 'primeng/primeng';
import { GrowlModule } from 'primeng/primeng';
import { MessageService } from 'primeng/components/common/messageservice';
import { InputTextModule } from 'primeng/primeng';
import { ButtonModule } from 'primeng/primeng';
import { ChipsModule } from 'primeng/primeng';

//Other NPM Packages
import { MaterializeModule } from 'angular2-materialize';
import { NgxBarcodeModule } from 'ngx-barcode';

@NgModule({
  declarations: [
    AppComponent,
    ItemsOverviewComponent,
    ItemDetailComponent,
    CategoryComponent,
    CategoriesComponent
  ],
  imports: [
    BrowserModule,
    MaterializeModule,
    NgxBarcodeModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    HttpModule,
    FormsModule,
    DataTableModule,
    SharedModule,
    GrowlModule,
    InputTextModule,
    ButtonModule,
    ChipsModule
  ],
  providers: [
    APIService,
    BaseRestService,
    MessageService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
