export class Item {
  public readonly id: number;
  public title: string;
  public barcode: string;
  public barcodeType: string;
  public location: string;
  public comment: string;
  public state: string;

  constructor(
    id: number,
    title: string,
    barcode: string,
    barcodeType: string,
    type: string,
    location: string,
    comment: string = '',
    state: string
  ) {
    this.id = id;
    this.title = title;
    this.barcode = barcode;
    (this.barcodeType = barcodeType), (this.location = location);
    this.comment = comment;
    this.state = state;
  }
}
