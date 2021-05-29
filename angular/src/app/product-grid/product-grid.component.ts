import { Component, OnInit } from '@angular/core';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { Product } from '../Interfaces/Product';
import { ProductServiceService } from '../Services/product-service.service';
@Component({
  selector: 'app-product-grid',
  templateUrl: './product-grid.component.html',
  styleUrls: ['./product-grid.component.css']
})
export class ProductGridComponent implements OnInit {

  products: Observable<Product>;
  constructor(private _productSrv: ProductServiceService) { }

  private LoadProducts() {
    this._productSrv.Get().then(result => {
      this.products = result;
    });
  }
  ngOnInit(): void {
    this.LoadProducts();
  }

}
