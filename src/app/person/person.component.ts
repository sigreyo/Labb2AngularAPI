import { Component, OnInit} from '@angular/core';

import { Person } from '../models/person.model';
import { PersonService } from '../service/person.service';


@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})

export class PersonComponent implements OnInit {

  constructor(private personService:PersonService ) { }

  persons:Person[] = []
  searchText = ''
  page = 1
  pageSize = 10

  ngOnInit(): void {
    this.getAllPersons()
  }
 
  getAllPersons(){    
    this.personService.getAllPersons().subscribe(
      res => this.persons = res                       
      )
  }
  
  
  
}
