import { combineAll } from 'rxjs/operator/combineAll';

export class Category {
  public id: number;
  public name: string;
  public comment?: string;
  public deviceCount: number;

  constructor(
    id: number,
    name: string,
    comment: string = '',
    deviceCount: number
  ) {
    this.id = id;
    this.name = name;
    this.comment = comment;
    this.deviceCount = deviceCount;
  }
}
