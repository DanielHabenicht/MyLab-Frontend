import { Component } from '@angular/core';
import { APIService } from '../services/api.service';
import { ActivatedRoute, Router, ParamMap } from '@angular/router';
import { Category } from '../common/classes/category.class';

@Component({
  selector: 'category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent {

  public category: Category;

  constructor(
    private route: ActivatedRoute,
    private apiService: APIService

  ) {

  }

  public ngOnInit() {
    this.route.paramMap.switchMap((params: ParamMap) =>
      this.apiService.getCategory(Number.parseInt(params.get('id') || '')))
      .subscribe(category => {
        if (category != null) {
          this.category = category;
        } else {
          this.category = new Category(-1, '', '', 4, false, 0);
        }
      });
  }

}
