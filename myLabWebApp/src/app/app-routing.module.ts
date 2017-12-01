import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CategoriesComponent } from './categories/categories-overview.component';
import { CategoryComponent } from './categories/category.component';
import { DeviceDetailComponent } from './devices/device-detail.component';
import { DevicesOverviewComponent } from './devices/devices-overview.component';

const routes: Routes = [
  { path: 'detail', component: DeviceDetailComponent },
  { path: 'detail/:id', component: DeviceDetailComponent },
  { path: 'list', component: DevicesOverviewComponent },
  { path: 'categories', component: CategoriesComponent },
  { path: 'category', component: CategoryComponent },
  { path: 'category/:id', component: CategoryComponent },
  { path: '', redirectTo: '/list', pathMatch: 'full' }
  //{ path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes,
    {
      //enableTracing: true // <-- debugging purposes only
    })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
