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

  public devices
  : Device[];

  constructor(
    private apiService: APIService
  ) {
    //TODO Replace with real API
    this.apiService.getDevices().subscribe(devices => {
      this.devices = devices;
    },
  error => {
    console.log('Errror here');
  });
  }

}
