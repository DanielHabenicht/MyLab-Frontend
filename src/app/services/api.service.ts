import { Observable, Observer } from 'rxjs';
import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { BaseRestService } from './baseRest.service';
import { Item } from '../common/classes/item.class';
import { DEVICES } from '../mocks/devices.mock';
import { Category } from '../common/classes/category.class';
import { CATEGORIES } from '../mocks/categories.mock';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/publishReplay';
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
   * Returns all items in an Array
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

    return Observable.of(DEVICES);
  }

  public getItem(id: number): Observable<Item | undefined> {
    return Observable.of(DEVICES.find(item => { return item.id === id; }));
    //TODO: Replace with real code
    //return this.baseRestService.getApiRequest('/items/' + id);
  }

  /**
   * Updates the item on the Server.
   * @param item item that has changed
   */
  public updateItem(item: Item): void {
    DEVICES.splice(DEVICES.indexOf(item), 1, item);
    //TODO Replace by real Code
  }

  /**
   * Deletes the item on the server
   * @param item item that should be deleted
   */
  public deleteItem(item: Item): void {
    //TODO Replace by real Code
    DEVICES.splice(DEVICES.indexOf(item), 1);
  }

  public addItem(item: Item): void {
    DEVICES.push(item);
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
