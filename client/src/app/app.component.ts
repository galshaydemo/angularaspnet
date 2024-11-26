import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  members:any;
  ngOnInit(): void {
    this.http.get("http://localhost:5204/Member").subscribe({
      next:response=>{
        console.log(response);
        this.members=response},
      error:error=> console.log(error),
      complete:()=>console.log('finish')
    })
  }
  http= inject(HttpClient)
  title = 'client1';
}
