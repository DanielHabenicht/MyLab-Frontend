import { Component } from '@angular/core';
import { Item } from '../common/classes/item.class';
import { ITEMS } from '../mocks/items.mock';
import 'rxjs/add/operator/switchMap';
import { APIService } from '../services/api.service';
import { ActivatedRoute, Router, ParamMap } from '@angular/router';
import { Observable } from 'rxjs/Observable';

@Component({
  selector: 'item-detail',
  templateUrl: './item-detail.component.html',
  styleUrls: ['./item-detail.component.scss']
})
export class ItemDetailComponent {

  public item: Observable<Item | undefined>;

  constructor(
    private apiService: APIService,
    private route: ActivatedRoute,
    private router: Router
  ) {

  }
  public ngOnInit() {
    this.item = this.route.paramMap
      .switchMap((params: ParamMap) =>
        this.apiService.getItem(Number.parseInt(params.get('id') || '')));
  }

}
