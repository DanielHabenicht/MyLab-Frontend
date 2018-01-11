export class Item {
  public readonly id: number;
  public title: string;
  public inventoryNumber: number;
  public type: string;
  public location: string;
  public comment: string;
  public state: string;

  constructor(
    id: number,
    title: string,
    inventoryNumber: number,
    type: string,
    location: string,
    comment: string = '',
    state: string
  ) {
    this.id = id;
    this.title = title;
    (this.inventoryNumber = inventoryNumber), (this.type = type);
    this.location = location;
    this.comment = comment;
    this.state = state;
  }
}
