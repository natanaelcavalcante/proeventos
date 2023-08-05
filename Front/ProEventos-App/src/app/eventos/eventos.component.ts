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

  //criando o binding de definição de tamanho da imagem
  widthImg: number = 50;
  marginImg: number = 3;

  //Implementando o construtor injetando o HttpClient dentro da variavel criada http
  constructor (private http: HttpClient){}

  ngOnInit(): void {
      this.getEventos();
  }

  /**
   * Método para coletar os dados na API
   */
  public getEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error)      
      );       
  }



}
