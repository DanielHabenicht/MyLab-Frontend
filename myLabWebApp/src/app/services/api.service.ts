import { Observable, Observer } from 'rxjs';
import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import 'rxjs/add/operator/map';
import { BaseRestService } from './baseRest.service';
import { Item } from '../common/classes/item.class';
import { ITEMS } from '../mocks/items.mock';
import { Category } from '../common/classes/category.class';
import { CATEGORIES } from '../mocks/categories.mock';

/**
 * A Service to communicate with the API
 *
 * @export
 * @class APIService
 */
@Injectable()
export class APIService {

  public items: Observable<Item[]>;

  constructor(
    private baseRestService: BaseRestService
  ) { }

  /**
   * Returns all Items in an Array
   */
  public getItems(): Observable<Item[]> {
    //TODO Replace with real Code
    // if (this.items != null) {
    //   return this.items;
    // }
    // const obs = this.baseRestService.getApiRequest('/items').publishReplay();
    // obs.connect();
    // this.items = obs;
    // return obs;
    return Observable.of(ITEMS);
  }

  public getItem(id: number): Observable<Item | undefined> {
    return Observable.of(ITEMS.find(item => { return item.id === id; }));
    //TODO: Replace with real code
    //return this.baseRestService.getApiRequest('/items/' + id);
  }

  /**
   * Updates the Item on the Server.
   * @param item Item that has changed
   */
  public updateItem(item: Item): void {
    ITEMS.splice(ITEMS.indexOf(item), 1, item);
    //TODO Replace by real Code
  }

  /**
   * Deletes the item on the server
   * @param item Item that should be deleted
   */
  public deleteItem(item: Item): void {
    //TODO Replace by real Code
    ITEMS.splice(ITEMS.indexOf(item), 1);
  }

  public addItem(item: Item): void {
    ITEMS.push(item);
  }

  public getCategories(): Observable<Category[]> {
    //TODO Replace with real Code
    return Observable.of(CATEGORIES);
  }

  public getCategory(id: number): Observable<Category | undefined> {
    //TODO: Replace with real Code
    return Observable.of(CATEGORIES.find(category => { return category.id === id; }));
  }
}
