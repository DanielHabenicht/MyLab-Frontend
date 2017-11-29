import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TableComponent } from './table/table.component';
import { ItemDetailComponent } from './item-detail/item-detail.component';

const routes: Routes = [
  { path: 'detail', component: ItemDetailComponent },
  { path: 'detail/:id', component: ItemDetailComponent },
  { path: 'list', component: TableComponent },
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
