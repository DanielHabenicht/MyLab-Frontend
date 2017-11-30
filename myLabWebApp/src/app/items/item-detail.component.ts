import { Component } from '@angular/core';
import { Item } from '../common/classes/item.class';
import { ITEMS } from '../mocks/items.mock';
import 'rxjs/add/operator/switchMap';
import { APIService } from '../services/api.service';
import { ActivatedRoute, Router, ParamMap } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { Location } from '@angular/common';

@Component({
  selector: 'item-detail',
  templateUrl: './item-detail.component.html',
  styleUrls: ['./item-detail.component.scss']
})
export class ItemDetailComponent {

  public item: Item;

  constructor(
    private apiService: APIService,
    private route: ActivatedRoute,
    private location: Location
  ) {

  }
  public ngOnInit() {
    this.route.paramMap.switchMap((params: ParamMap) =>
      this.apiService.getItem(Number.parseInt(params.get('id') || '')))
      .subscribe(item => {
        if (item != null) {
          this.item = item;
        } else {
          this.item = new Item(-1, '', '', '');
        }
      });
  }

  public save() {
    this.apiService.updateItem(this.item);
    this.location.back();
  }

  public delete() {
    this.apiService.deleteItem(this.item);
    this.location.back();
  }

  public saveNew() {
    this.apiService.addItem(this.item);
    this.location.back();
  }

}