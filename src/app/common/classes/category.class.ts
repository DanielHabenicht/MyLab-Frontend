import { combineAll } from 'rxjs/operator/combineAll';

export class Category {
  public id: number;
  public title: string;
  public comment: string;
  public laboratoryId: number;
  public isTemplate: boolean;
  public deviceCount: number;

  constructor(
    id: number,
    title: string,
    comment: string,
    laboratoryId: number,
    isTemplate: boolean,
    deviceCount: number
  ) {
    this.id = id;
    this.title = title;
    this.comment = comment;
    this.laboratoryId = laboratoryId;
    this.isTemplate = isTemplate;
    this.deviceCount = deviceCount;
  }
}
