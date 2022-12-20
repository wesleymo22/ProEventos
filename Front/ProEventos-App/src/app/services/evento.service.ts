import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EventoService {

baseUrl = 'https://localhost:7024/api/Eventos/'

constructor(private http: HttpClient) { }

getEvento(){
  return this.http.get(this.baseUrl)
}
}
