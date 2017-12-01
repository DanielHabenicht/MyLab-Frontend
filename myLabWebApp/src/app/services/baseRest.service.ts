
import { Observable } from 'rxjs/Observable';
import { Injectable } from '@angular/core';
import { Http, Headers, Response } from '@angular/http';

import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
/**
 * A Service to do all restcall's
 *
 * @export
 * @class BaseRestService
 */
@Injectable()
export class BaseRestService {

  private baseURL: string = '/api';

  constructor(
    private http: Http
  ) { }

  /**
   *
   * @param path The path appended to the URL without '/'
   */
  public getApiRequest(path: string): Observable<any> {
    return this.runRestQuery(this.baseURL + path);
  }

  private runRestQuery(url: string): Observable<any> {
    const header = new Headers({
      Accept: 'application/json; odata=verbose'
    });
    return this.http.get(url, { headers: header })
      .map(data => data.json())
      .catch((err: Response) => {
        return Observable.throw(err.json());
      });
  }
}