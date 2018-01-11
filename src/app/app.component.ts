import { Component, HostListener } from '@angular/core';
import { Router } from '@angular/router';
import { Message } from 'primeng/primeng';
import { APIService } from './services/api.service';
import { Item } from './common/classes/item.class';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  private readonly FILTER_DEBOUNCE_TIME = 100;
  private searchFilter: number | null = null;

  @HostListener('window:keyup', ['$event'])
  public keyEvent(event: KeyboardEvent) {
    const character = new RegExp('\\w');
    if (event.key != null && character.test(event.key)) {
      this.searchstring = this.searchstring.concat(event.key);
    }
    if (this.searchFilter != null) {
      window.clearTimeout(this.searchFilter);
    }
    this.searchFilter = window.setTimeout(() => {
      this.searchForBarcode();
    }, this.FILTER_DEBOUNCE_TIME);
  }
  public get location(): string {
    return this.router.url;
  }

  public searchstring: string = '';

  public devices: Item[] = new Array();

  public msgs: Message[] = [];

  constructor(
    private router: Router,
    private apiService: APIService

  ) {
    this.apiService.getItems().subscribe(devices => {
      this.devices = devices;
    });

  }

  public searchForBarcode() {
    const regex = new RegExp('^\\d{6}$');
    if (this.searchstring === '') {
      return;
    }
    if (!regex.test(this.searchstring)) {
      this.searchstring = '';
      return;
    }
    console.log(this.searchstring);
    //this.router.navigate(['device/' + this.searchstring]);

  }
}
