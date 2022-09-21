import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Associate } from '../Models/Associate';

@Injectable({
  providedIn: 'root'
})
export class AssociateServiceService {

  constructor(private http: HttpClient) { }

  private rootUrl = '';

  public getAssociates(): Observable<Associate[]>{
    return this.http.get<Associate[]>( this.rootUrl + '/api/associate');
  }
}
