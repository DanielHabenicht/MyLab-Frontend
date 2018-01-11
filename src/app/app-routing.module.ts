import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CategoriesComponent } from './categories/categories-overview.component';
import { CategoryComponent } from './categories/category.component';
import { ItemDetailComponent } from './items/item-detail.component';
import { ItemsOverviewComponent } from './items/items-overview.component';

const routes: Routes = [
  { path: 'device', component: ItemDetailComponent },
  { path: 'device/:id', component: ItemDetailComponent },
  { path: 'devices', component: ItemsOverviewComponent },
  { path: 'categories', component: CategoriesComponent },
  { path: 'category', component: CategoryComponent },
  { path: 'category/:id', component: CategoryComponent },
  { path: '', redirectTo: '/devices', pathMatch: 'full' }
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
