import { Component, HostListener } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { MenubarModule } from 'primeng/menubar';
import { BadgeModule } from 'primeng/badge';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

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
      url: '/store'
      // style: {
      //   'margin-left': '50px'
      // }
    },
    {
      label: '自採預約',
      icon: 'pi pi-star',
      url: '/selfpick'
    },
    {
      label: '環境介紹',
      icon: 'pi pi-image',
      url: '/environment'
    },
    {
      label: '購物車',
      icon: 'pi pi-shopping-cart',
      url: '/shoppingcart'
    },
    {
      label: '關於果園',
      icon: 'pi pi-info-circle',
      badge: '1',
      items: [

        {
          label: '位置資訊',
          icon: 'pi pi-map-marker',
          url: '/location'
        },
        {
          label: '聯繫我們',
          icon: 'pi pi-envelope',
          url: '/contact'
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
              icon: 'pi ',
              url: '/recruit/pick'
            }
          ]
        }
      ]
    }
  ];

  constructor(private router: Router) { }

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

  menuItm_Click(url: string) {
    if (!!url) {
      this.router.navigate([url])
    }
  }

  login(){
    this.router.navigate(['/login'])
  }
}
