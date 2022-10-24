import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'client';
  users : any = []
  error: any;
  constructor(private http : HttpClient){

  }
  ngOnInit() {
      return this.http.get('https://localhost:5001/api/users').subscribe({
      next:(data)=> this.users = data,
      error: (error)=> this.error = this.error    

  })
  }
}
