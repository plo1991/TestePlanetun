import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  numeros: string = '';
  resultados: string[] = [];
  apiUrl: string = 'https://localhost:7107/api/tabuada'; // endereço da API
  
  constructor(private http: HttpClient) {}

  ngOnInit() { }

  processarTabuada() {
    const numerosArray = this.numeros.split(',').map(Number);

    this.http.post<string[]>(this.apiUrl, numerosArray).subscribe(
      (data) => {
        this.resultados = data;
      },
      (error) => {
        console.error('Erro ao chamar a API', error);
      }
    );
  }

  title = 'TestePlanetun';
}
