import { Observable, Observer } from 'rxjs';
import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { BaseRestService } from './baseRest.service';
import { Device } from '../common/classes/device.class';
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

  public devices: Observable<Device[]>;

  constructor(
    private baseRestService: BaseRestService
  ) { }

  /**
   * Returns all devices in an Array
   */
  public getDevices(): Observable<Device[]> {
    //TODO Replace with real Code
    if (this.devices != null) {
      return this.devices;
    }
    const obs = this.baseRestService.getApiRequest('/device').publishReplay();
    obs.connect();
    this.devices = obs;
    return obs;
    //return Observable.of(deviceS);
  }

  public getDevice(id: number): Observable<Device | undefined> {
    return Observable.of(DEVICES.find(device => { return device.id === id; }));
    //TODO: Replace with real code
    //return this.baseRestService.getApiRequest('/devices/' + id);
  }

  /**
   * Updates the device on the Server.
   * @param device device that has changed
   */
  public updateDevice(device: Device): void {
    DEVICES.splice(DEVICES.indexOf(device), 1, device);
    //TODO Replace by real Code
  }

  /**
   * Deletes the device on the server
   * @param device device that should be deleted
   */
  public deleteDevice(device: Device): void {
    //TODO Replace by real Code
    DEVICES.splice(DEVICES.indexOf(device), 1);
  }

  public addDevice(device: Device): void {
    DEVICES.push(device);
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
