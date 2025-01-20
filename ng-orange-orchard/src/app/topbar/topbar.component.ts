import { Component } from '@angular/core';
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
  items: MenuItem[] | undefined = [
    {
      label: '商品',
      icon: 'pi pi-home',
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
      icon: 'pi pi-bolt'
    },
    {
      label: '購物車',
      icon: 'pi pi-envelope'
    },
    {
      label: '關於我們',
      icon: 'pi pi-search',
      badge: '1',
      items: [

        {
          label: '位置資訊',
          icon: 'pi pi-server'
        },
        {
          label: '聯繫我們',
          icon: 'pi pi-pencil'
        },
        {
          separator: true,
        },
        {
          label: '人員募集',
          icon: 'pi pi-palette',
          badge: '1',
          items: [
            {
              label: '採集員/兼職',
              icon: 'pi pi-palette'
            }
          ]
        }
      ]
    }
  ];
}
