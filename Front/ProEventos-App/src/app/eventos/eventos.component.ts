
import { Component, OnInit } from '@angular/core';
import { EventoService } from '../services/evento.service';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  public eventosFiltrados: any = [];
  exibirImagem = true;
  private _filtroLista = '';

  public get filtroLista(){
    return this._filtroLista
  }

  public set filtroLista(value: string){
    this._filtroLista = value
    this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista): this.eventos
  }

  filtrarEventos(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLowerCase();
    return this.eventos.filter(
      (e: any) => e.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      e.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1

    );
  }


  constructor(private eventoService: EventoService) { }

  ngOnInit(): void {
    this.getEventos();
  }

  alterarImagem(){
    this.exibirImagem = !this.exibirImagem;
  }



  public getEventos(): any {
    this.eventoService.getEvento().subscribe(
      response => {
        this.eventos = response
        this.eventosFiltrados = this.eventos
      },
      error => console.log(error)
    );
  }
}
