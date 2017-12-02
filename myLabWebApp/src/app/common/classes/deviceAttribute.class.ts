export class DeviceAttribute {
  public readonly id: number;
  public title: string;
  public datatypeId: number;

  constructor(id: number, title: string, datatypeId: number) {
    this.id = id;
    this.title = title;
    this.datatypeId = datatypeId;
  }
}
