export class Item {
  public readonly id: number;
  public name: string;
  public location: string;
  public comment?: string;

  constructor(
    id: number,
    name: string,
    location: string,
    comment: string = ''
  ) {
    this.id = id;
    this.name = name;
    this.location = location;
    this.comment = comment;
  }
}
