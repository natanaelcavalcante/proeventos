import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  //definindo a variavel eventos como any que recebe um array
  public eventos: any = [];
  public eventosFiltrados: any = [];

  //criando o binding de definição de tamanho da imagem
  widthImg: number = 150;
  marginImg: number = 3;
  exibirImg: boolean = true;

  //Exemplo Two way data binding
  private _filtroLista: string = '';

   
  public get filtroLista(): string {
    return this._filtroLista;
  }
  
    public set filtroLista (value : string) {
    this._filtroLista = value;
    //verifica se há alguma informação no filtroLista e coloca dentro do metodo filtrarEvento se não retorna eventos
    this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
  }

  filtrarEventos(filtrarPor: string): any {

    filtrarPor = filtrarPor.toLocaleLowerCase();
    //Coleta todos os eventos e filtra com a função abaixo. O filter é nativo do JS
    return this.eventos.filter(
      (evento: any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 || 
      evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )

  }
  

  //Implementando o construtor injetando o HttpClient dentro da variavel criada http
  constructor (private http: HttpClient){}

  ngOnInit(): void {
      this.getEventos();
  }

  alterarImg(){
    this.exibirImg = !this.exibirImg;
  }

  /**
   * Método para coletar os dados na API
   */
  public getEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => {
        this.eventos = response
        this.eventosFiltrados = this.eventos      
      },
      error => console.log(error)      
      );       
  }



}
