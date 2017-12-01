import { Component } from '@angular/core';
import { Device } from '../common/classes/device.class';
import { DEVICES } from '../mocks/devices.mock';
import { Router } from '@angular/router';
import { APIService } from '../services/api.service';

@Component({
  selector: 'devices-overview',
  templateUrl: './devices-overview.component.html',
  styleUrls: ['./devices-overview.component.scss']
})
export class DevicesOverviewComponent {

  public devices : Device[];
  public selectedDevices: Device[];
  public loading: boolean = true;
  public multiselect: boolean = false;

  constructor(
    private apiService: APIService
  ) {
    //TODO Replace with real API
    this.apiService.getDevices().subscribe(devices => {
      this.devices = devices;
      this.loading = false;
    },
    error => {
    console.log('Errror here');
    });
  }

  public isPaging(): boolean {
    if (this.devices != null) {
      return this.devices.length > 20;
    }else {
      return false;
    }
  }

  public toggleMultiselect() {
    this.multiselect = !this.multiselect;
  }
}
