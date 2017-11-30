import { Component, Input } from '@angular/core';
import { Item } from '../common/classes/item.class';
import { OnInit } from '@angular/core/src/metadata/lifecycle_hooks';
@Component({
  selector: 'custom-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.scss']
})
export class TableComponent implements OnInit {

  @Input()
  public rows: any[];

  public ngOnInit() {
    this.determineMode();
    console.log('Hey!');
  }

  public determineMode() {
    if (this.rows[0] instanceof Item) {
      console.log('Items!');
    } else {
      console.log('Categories!');
    }
  }
}
