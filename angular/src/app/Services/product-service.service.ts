import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';


import { Product } from '../Interfaces/Product';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {
  private _ServiceURL: string;
  constructor(private _http: Http) {
    this._ServiceURL = `${environment.apiUrl}`;
  }

  Get(): Promise<Observable<Product>>{
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    var comando = 'products';
    return this._http.post(`${this._ServiceURL}${comando}`, options).toPromise()
      .then(function (result) {
        return this.extractData(result);
      }.bind(this))
      .catch(function (result) {
        return this.extractData(result);
      });
  }
}
