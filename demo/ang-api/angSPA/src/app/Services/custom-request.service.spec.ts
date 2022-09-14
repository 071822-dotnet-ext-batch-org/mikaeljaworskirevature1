import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Time } from '../Models/time';
import { Todo } from '../Models/Todo';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})

export class CustomRequestService{

  private ApiUrl = 'https://localhost:7236';
  private JPHURL = 'https://jsonplaceholder.typicode.com'

  constructor(private http: HttpClient) { }

  public getTime(): Observable<Time> 
  {
    return this.http.get<Time>(this.ApiUrl + "/time");
  }

  public getTodos(): Observable<Todo[]>
  {
    return this.http.get<Todo[]>(this.JPHURL + "/Todo");
  }

}


