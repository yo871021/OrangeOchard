import { Component } from '@angular/core';
import { DataViewModule } from 'primeng/dataview';
import { ButtonModule } from 'primeng/button';
import { Tag } from 'primeng/tag';
import { DropdownModule } from 'primeng/dropdown';
import { CardModule } from 'primeng/card';
import { InputNumberModule } from 'primeng/inputnumber';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { OverlayBadgeModule } from 'primeng/overlaybadge';
import { StoreService } from './service/store.service';

@Component({
  selector: 'app-store',
  imports: [DataViewModule, ButtonModule, Tag, CommonModule, DropdownModule,
    InputNumberModule, CardModule, FormsModule, OverlayBadgeModule],
  templateUrl: './store.component.html',
  styleUrl: './store.component.scss'
})
export class StoreComponent {

  products: any[] = [];

  constructor(private storeService: StoreService) { }

  ngOnInit() {
    this.storeService.GetProducts().subscribe(_products => {
      this.products = _products.map((product: any) => ({ ...product, ShopCart_Qty: 0 }));
    })
  }

  getSeverity(product: any) {
    switch (product.inventoryStatus) {
      case 'INSTOCK':
        return 'success';

      case 'LOWSTOCK':
        return 'warn';

      case 'OUTOFSTOCK':
        return 'danger';

      default:
        return undefined;
    }
  };

  shopCartClick(product: any) {
    // 如果 ShopCart_Qty 是 falsy（undefined、0 等），先加 10
    if (!product.ShopCart_Qty) {
      product.ShopCart_Qty += 10;
    }
    product.isModify = true;

    // 每次呼叫都「重置」計時器
    this.resetTimer(product);
  }

  qtyInput(product: any, event: any) {
    const inputElem = event.target as HTMLInputElement;
    inputElem.value = inputElem.value.replace(/^0+/, '');    // 去掉前導零
    inputElem.value = inputElem.value.replace(/[^\d]/g, ''); // 去掉非數字
    this.resetTimer(product);
  }

  qtyChange(product: any, qty: number) {

    product.ShopCart_Qty += qty;

    if (product.ShopCart_Qty >= 10) {

      product.isModify = true;
      this.resetTimer(product);

    } else {

      clearTimeout(product._changeTimer);
      product.isModify = false;
    }
  }

  resetTimer(product: any) {

    if (product._changeTimer) {
      clearTimeout(product._changeTimer);
    }

    product._changeTimer = setTimeout(() => {
      product.ShopCart_Qty = Math.floor(product.ShopCart_Qty / 10) * 10;
      product.isModify = false;
    }, 2000);
  }

}
