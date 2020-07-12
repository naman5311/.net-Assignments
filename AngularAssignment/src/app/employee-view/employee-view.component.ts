import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';

@Component({
  selector: 'app-employee-view',
  templateUrl: './employee-view.component.html',
  styleUrls: ['./employee-view.component.css']
})
export class EmployeeViewComponent implements OnInit {
list:Employee[]
  constructor() {
    this.list=[
      {eid:1,ename:'pqr',design:'sde',doj:new Date(2020,7,20),salary:50000},
      {eid:2,ename:'abc',design:'sde',doj:new Date(2020,7,20),salary:50000},
      {eid:3,ename:'xyz',design:'sde',doj:new Date(2020,7,20),salary:50000},
    ]
   }

  ngOnInit(): void {
  }

}
