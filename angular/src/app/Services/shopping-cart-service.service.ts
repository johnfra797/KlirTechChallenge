import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';


import { ShoppingCart } from '../Interfaces/ShoppingCart';
import { ShoppingCartCreateResponse } from '../Interfaces/ShoppingCartCreateResponse';
import { ShoppingCartRequest } from '../Interfaces/ShoppingCartRequest';

import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ShoppingCartServiceService {
  private _ServiceURL: string;
  constructor(private _http: Http) {
    this._ServiceURL = `${environment.apiUrl}`;
  }

  Create(shoppingCart: ShoppingCart): Promise<ShoppingCartCreateResponse> {
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    var comando = 'shoppingCart';
    return this._http.post(`${this._ServiceURL}${comando}`, shoppingCart, options).toPromise()
      .then(function (result) {
        return this.extractData(result);
      }.bind(this))
      .catch(function (result) {
        return this.extractData(result);
      });
  }

  Get(shoppingCartRequest: ShoppingCartRequest): Promise<ShoppingCart> {
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    var comando = 'get/shoppingCart';
    return this._http.post(`${this._ServiceURL}${comando}`, shoppingCartRequest, options).toPromise()
      .then(function (result) {
        return this.extractData(result);
      }.bind(this))
      .catch(function (result) {
        return this.extractData(result);
      });
  }
  extractData(res: Response) {
    let body = res.json();
    return body || {}; 
  }

}
