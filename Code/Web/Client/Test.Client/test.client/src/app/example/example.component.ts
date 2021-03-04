import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'am-example',
  templateUrl: './example.component.html',
  styleUrls: ['./example.component.scss']
})
export class ExampleComponent implements OnInit {

  constructor() {
    // inject the needed dependencies in this constructor.
  }

  ngOnInit() {
    // initialze values here instead of the constructor
  }
}
