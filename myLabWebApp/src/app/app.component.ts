import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Message } from 'primeng/primeng';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  public get location(): string {
    return this.router.url;
  }

  public msgs: Message[] = [];

  constructor(private router: Router) {

  }
}
