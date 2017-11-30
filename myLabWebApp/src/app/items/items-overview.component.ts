import { Component } from '@angular/core';
import { Item } from '../common/classes/item.class';
import { ITEMS } from '../mocks/items.mock';
import { Router } from '@angular/router';
import { APIService } from '../services/api.service';

@Component({
  selector: 'items-overview',
  templateUrl: './items-overview.component.html',
  styleUrls: ['./items-overview.component.scss']
})
export class ItemsOverviewComponent {

  public items: Item[];

  constructor(
    private apiService: APIService
  ) {
    //TODO Replace with real API
    this.apiService.getItems().subscribe(items => {
      this.items = items;
    });
  }

}
