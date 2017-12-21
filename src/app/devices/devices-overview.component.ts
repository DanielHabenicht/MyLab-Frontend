import { Message } from 'primeng/primeng';
import { MessageService } from 'primeng/components/common/messageservice';
import { Component, ViewEncapsulation } from '@angular/core';
import { Device } from '../common/classes/device.class';
import { DEVICES } from '../mocks/devices.mock';
import { Router } from '@angular/router';
import { APIService } from '../services/api.service';
import { Event } from '@angular/router/src/events';
import { DataTableModule,SharedModule } from 'primeng/primeng';

@Component({
  selector: 'devices-overview',
  templateUrl: './devices-overview.component.html',
  styleUrls: ['./devices-overview.component.scss'], 
  encapsulation: ViewEncapsulation.None
})
export class DevicesOverviewComponent {

  public devices: Device[];
  public selectedDevices: Device[];
  public loading: boolean = true;
  public multiselect: boolean = false;
  public chips: string[] = new Array(); 

  constructor(
    private apiService: APIService,
    private messageService: MessageService,
    private router: Router
  ) {
    //TODO Replace with real API
    this.apiService.getDevices().subscribe(devices => {
      this.devices = devices;
      this.loading = false;
    },
      error => {
        this.messageService.add(
          {
            severity: 'error',
            summary: 'Keine Verbindung zum Server',
            detail: 'Die Anwendung konnte keine Inventargegenstände abrufen'
          }
        );
      });
  }

  public isPaging(): boolean {
    if (this.devices != null) {
      return this.devices.length > 20;
    } else {
      return false;
    }
  }

  public onRowClick(event: any): void {
    if (this.multiselect) {
      return;
    } else {
      this.router.navigate(['/device/' + event.data.id]);
    }
  }

  public toggleMultiselect() {
    this.multiselect = !this.multiselect;
  }

}
