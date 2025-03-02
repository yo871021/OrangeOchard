import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';

@Injectable({
  providedIn: 'root'
})
export class StoreService {

  constructor(private http: HttpClient) { }

  GetProducts() {
    return this.http.post<any>(`${environment.apiUrl}/Store/GetProducts`, {});
  }
}
