import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-associate-list',
  templateUrl: './associate-list.component.html',
  styleUrls: ['./associate-list.component.css']
})
export class AssociateListComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    this.getAssociates()
  }

  getAssociates(): void {
    //get request to be triggered!
  }

}
