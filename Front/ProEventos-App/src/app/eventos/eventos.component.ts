import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  exibirImagem = true;
  filtroLista = '';

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  alterarImagem(){
    this.exibirImagem = !this.exibirImagem;
  }



  public getEventos(): any {
    this.http.get('https://localhost:7024/api/eventos/').subscribe(
      respose => this.eventos = respose,
      error => console.log(error)
    );
  }
}
