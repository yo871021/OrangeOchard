import { Component, HostListener } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { MenubarModule } from 'primeng/menubar';
import { BadgeModule } from 'primeng/badge';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-topbar',
  imports: [MenubarModule, CommonModule, BadgeModule],
  templateUrl: './topbar.component.html',
  styleUrl: './topbar.component.scss'
})
export class TopbarComponent {
  isItmTitle: boolean = true;
  items: MenuItem[] | undefined = [
    {
      label: '商品',
      icon: 'pi pi-shop',
      // style: {
      //   'margin-left': '50px'
      // }
    },
    {
      label: '自採預約',
      icon: 'pi pi-star'
    },
    {
      label: '環境介紹',
      icon: 'pi pi-image'
    },
    {
      label: '購物車',
      icon: 'pi pi-shopping-cart'
    },
    {
      label: '關於果園',
      icon: 'pi pi-info-circle',
      badge: '1',
      items: [

        {
          label: '位置資訊',
          icon: 'pi pi-map-marker'
        },
        {
          label: '聯繫我們',
          icon: 'pi pi-envelope'
        },
        {
          separator: true,
        },
        {
          label: '人員募集',
          icon: 'pi pi-address-book',
          badge: '1',
          items: [
            {
              label: '採集員/兼職',
              icon: 'pi '
            }
          ]
        }
      ]
    }
  ];

  ngOnInit() {
    this.checkViewport();
  }

  @HostListener('window:resize', [])
  onResize() {
    this.checkViewport();
  }
  private checkViewport() {
    this.isItmTitle = window.innerWidth > 960;
  }
}
