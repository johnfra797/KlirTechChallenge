import { Component, OnInit } from '@angular/core';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { ShoppingCart } from '../Interfaces/ShoppingCart';
import { ShoppingCartCreateResponse } from '../Interfaces/ShoppingCartCreateResponse';
import { ShoppingCartRequest } from '../Interfaces/ShoppingCartRequest';
import { ShoppingCartServiceService } from '../Services/shopping-cart-service.service';
@Component({
  selector: 'app-shopping-cart',
  templateUrl: './shopping-cart.component.html',
  styleUrls: ['./shopping-cart.component.css']
})
export class ShoppingCartComponent implements OnInit {

  shoppingCartResponse: ShoppingCartCreateResponse;
  constructor(private _shoppingCartSrv: ShoppingCartServiceService) { }

  private GetShoppingCart(id: Number) {
    let shoppingCartRequest = new ShoppingCartRequest();
    shoppingCartRequest.Id = id;
    this._shoppingCartSrv.Get(shoppingCartRequest).then(result => {
      this.shoppingCartResponse = result;
    });
  }
  private CreateShoppingCart(shoppingCart: ShoppingCart) {
    this._shoppingCartSrv.Create(shoppingCart).then(result => {
      this.shoppingCartResponse = result;
    });
  }

  ngOnInit(): void {
  }

}
