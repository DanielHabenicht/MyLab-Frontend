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
import { DeviceDetailComponent } from './devices/device-detail.component';
import { DevicesOverviewComponent } from './devices/devices-overview.component';
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

@NgModule({
  declarations: [
    AppComponent,
    DevicesOverviewComponent,
    DeviceDetailComponent,
    CategoryComponent,
    CategoriesComponent
  ],
  imports: [
    BrowserModule,
    MaterializeModule,
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
