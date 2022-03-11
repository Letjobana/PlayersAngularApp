import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';
  public players: Player[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Player[]>(baseUrl + 'api/Player').subscribe(result => {
      this.players = result;
    }, error => console.error(error));
  }
}

interface Player {
  id: number;
  name: string;
  shirtNo: number;
  appearances: number;
  goals: number;
  positionName: number;
  goalsPerMatch: number;
}
