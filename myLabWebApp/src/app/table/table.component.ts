import { Component } from '@angular/core';
import { Item } from '../common/classes/item.class';
import { ITEMS } from '../mocks/items.mock';
import { Router } from '@angular/router';
import { APIService } from '../services/api.service';

@Component({
  selector: 'custom-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.scss']
})
export class TableComponent {

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
