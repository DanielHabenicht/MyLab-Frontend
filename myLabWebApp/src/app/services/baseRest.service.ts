
import { Observable, Observer } from 'rxjs';
import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import 'rxjs/add/operator/map';

/**
 * A Service to do all restcall's
 *
 * @export
 * @class BaseRestService
 */
@Injectable()
export class BaseRestService {

  private apiUrl: string = 'http:/localhost:4200/api';

  constructor(
    private http: Http
  ) { }

  /**
   *
   * @param path The path appended to the URL without '/'
   */
  public getApiRequest(path: string): Observable<any> {
    return this.runRestQuery(this.apiUrl + path);
  }

  private runRestQuery(url: string): Observable<any> {
    const header = new Headers({
      Accept: 'application/json; odata=verbose'
    });
    return this.http.get(url, { headers: header })
      .map(data => data.json());
  }
}
