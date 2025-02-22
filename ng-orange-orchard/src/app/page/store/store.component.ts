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

@Component({
  selector: 'app-store',
  imports: [DataViewModule, ButtonModule, Tag, CommonModule, DropdownModule,
    InputNumberModule, CardModule, FormsModule, OverlayBadgeModule],
  templateUrl: './store.component.html',
  styleUrl: './store.component.scss'
})
export class StoreComponent {

  products: any[] = [
    {
      id: '1000',
      code: 'f230fh0g3',
      name: '椪柑',
      subname: '(中)',
      description: 'Product Description',
      image: 'bamboo-watch.jpg',
      price: 30,
      size: '23 ~ 25',
      quantity: 0,
      inventoryStatus: 'INSTOCK',
      rating: 5
    },
    {
      id: '1001',
      code: 'nvklal433',
      name: '椪柑',
      subname: '(大)',
      description: 'Product Description',
      image: 'black-watch.jpg',
      price: 35,
      size: '27 ~ 29',
      quantity: 0,
      inventoryStatus: 'OUTOFSTOCK',
      rating: 4
    },
    {
      id: '1000',
      code: 'f230fh0g3',
      name: '桶柑',
      subname: '(中)',
      description: 'Product Description',
      image: 'bamboo-watch.jpg',
      price: 30,
      size: '23 ~ 25',
      quantity: 0,
      inventoryStatus: 'INSTOCK',
      rating: 5
    },
    {
      id: '1001',
      code: 'nvklal433',
      name: '桶柑',
      subname: '(大)',
      description: 'Product Description',
      image: 'black-watch.jpg',
      price: 35,
      size: '27 ~ 29',
      quantity: 0,
      inventoryStatus: 'OUTOFSTOCK',
      rating: 4
    },
    {
      id: '1002',
      code: 'zz21cz3c1',
      name: '茂谷',
      description: 'Product Description',
      image: 'blue-band.jpg',
      price: 50,
      size: 'Fitness',
      quantity: 0,
      inventoryStatus: 'LOWSTOCK',
      rating: 3
    },
    {
      id: '1003',
      code: '244wgerg2',
      name: '帝王柑',
      description: 'Product Description',
      image: 'blue-t-shirt.jpg',
      price: 50,
      size: 'Clothing',
      quantity: 0,
      inventoryStatus: 'INSTOCK',
      rating: 5
    },
    {
      id: '1004',
      code: 'h456wer53',
      name: '砂糖橘',
      description: 'Product Description',
      image: 'bracelet.jpg',
      price: 50,
      size: 'Accessories',
      quantity: 0,
      inventoryStatus: 'INSTOCK',
      rating: 4
    },
    {
      id: '1005',
      code: 'av2231fwg',
      name: '佛利蒙',
      description: 'Product Description',
      image: 'brown-purse.jpg',
      price: 50,
      size: 'Accessories',
      quantity: 0,
      inventoryStatus: 'OUTOFSTOCK',
      rating: 4
    },
    {
      id: '1006',
      code: 'bib36pfvm',
      name: '紅肉柳丁',
      description: 'Product Description',
      image: 'chakra-bracelet.jpg',
      price: 50,
      size: 'Accessories',
      quantity: 0,
      inventoryStatus: 'LOWSTOCK',
      rating: 3
    },
    {
      id: '1007',
      code: 'mbvjkgip5',
      name: '黃肉柳丁',
      description: 'Product Description',
      image: 'galaxy-earrings.jpg',
      price: 50,
      size: 'Accessories',
      quantity: 0,
      inventoryStatus: 'INSTOCK',
      rating: 5
    }
  ]

  ngOnInit() {
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
    // 如果 quantity 是 falsy（undefined、0 等），先加 10
    if (!product.quantity) {
      product.quantity += 10;
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

    product.quantity += qty;

    if (product.quantity >= 10) {

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
      product.quantity = Math.floor(product.quantity / 10) * 10;
      product.isModify = false;
    }, 2000);
  }

}
