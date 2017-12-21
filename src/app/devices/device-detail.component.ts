import { Component } from '@angular/core';
import { Device } from '../common/classes/device.class';
import { DEVICES } from '../mocks/devices.mock';
import 'rxjs/add/operator/switchMap';
import { APIService } from '../services/api.service';
import { ActivatedRoute, Router, ParamMap } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { Location } from '@angular/common';

@Component({
  selector: 'device-detail',
  templateUrl: './device-detail.component.html',
  styleUrls: ['./device-detail.component.scss']
})
export class DeviceDetailComponent {

  public device: Device;

  constructor(
    private apiService: APIService,
    private route: ActivatedRoute,
    private location: Location
  ) {

  }
  public ngOnInit() {
    this.route.paramMap.switchMap((params: ParamMap) =>
      this.apiService.getDevice(Number.parseInt(params.get('id') || '')))
      .subscribe(device => {
        if (device != null) {
          this.device = device;
        } else {
          this.device = new Device(-1, '', 0, '', '', '', '');
        }
      });
  }

  public save() {
    this.apiService.updateDevice(this.device);
    this.location.back();
  }

  public delete() {
    this.apiService.deleteDevice(this.device);
    this.location.back();
  }

  public saveNew() {
    this.apiService.addDevice(this.device);
    this.location.back();
  }

}
