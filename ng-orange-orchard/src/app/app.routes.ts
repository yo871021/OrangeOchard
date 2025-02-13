import { Routes } from '@angular/router';
import { StoreComponent } from './page/store/store.component';
import { SelfpickComponent } from './page/selfpick/selfpick.component';
import { EnvironmentComponent } from './page/environment/environment.component';
import { ShoppingcartComponent } from './page/shoppingcart/shoppingcart.component';
import { MapComponent } from './page/map/map.component';
import { LocationComponent } from './page/location/location.component';
import { ContactComponent } from './page/contact/contact.component';
import { RecruitComponent } from './page/recruit/recruit.component';
import { LoginComponent } from './page/login/login.component';

export const routes: Routes = [
    { path: '', redirectTo: 'store', pathMatch: 'full' },
    { path: 'store', component: StoreComponent },
    { path: 'selfpick', component: SelfpickComponent },
    { path: 'environment', component: EnvironmentComponent },
    { path: 'shoppingcart', component: ShoppingcartComponent },
    { path: 'map', component: MapComponent },
    { path: 'location', component: LocationComponent },
    { path: 'contact', component: ContactComponent },
    { path: 'recruit', component: RecruitComponent },
    { path: 'login', component: LoginComponent },
    { path: '**', redirectTo: 'store' },
];
