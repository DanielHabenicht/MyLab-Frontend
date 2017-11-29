import { Observable, Observer } from 'rxjs';
import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import 'rxjs/add/operator/map';
import { BaseRestService } from './baseRest.service';
import { Item } from '../common/classes/item.class';

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
    if (this.items != null) {
      return this.items;
    }
    const obs = this.baseRestService.getApiRequest('/items').publishReplay();
    obs.connect();
    this.items = obs;
    return obs;
  }
}
