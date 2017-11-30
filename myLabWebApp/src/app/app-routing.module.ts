import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ItemDetailComponent } from './items/item-detail.component';
import { CategoriesComponent } from './categories/categories-overview.component';
import { ItemsOverviewComponent } from './items/items-overview.component';

const routes: Routes = [
  { path: 'detail', component: ItemDetailComponent },
  { path: 'detail/:id', component: ItemDetailComponent },
  { path: 'list', component: ItemsOverviewComponent },
  { path: 'categories', component: CategoriesComponent },
  { path: 'category', component: CategoriesComponent },
  { path: 'category/:id', component: CategoriesComponent },
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
