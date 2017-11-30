import { Component } from '@angular/core';
import { Category } from '../common/classes/category.class';
import { APIService } from '../services/api.service';

@Component({
  selector: 'categories-overview',
  templateUrl: './categories-overview.component.html',
  styleUrls: ['./categories-overview.component.scss']
})
export class CategoriesComponent {

  public categories: Category[];
  constructor(
    private apiService: APIService
  ) {
    this.apiService.getCategories().subscribe(categories => {
      this.categories = categories;
    });
  }

}
