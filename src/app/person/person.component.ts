import { Component, OnInit } from '@angular/core';
import { Department } from '../models/department.model';

import { Person } from '../models/person.model';
import { PersonService } from '../service/person.service';
import { DepartmentService } from '../service/department.service';


@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})

export class PersonComponent implements OnInit {

  constructor(
    private personService: PersonService,
    private depService: DepartmentService) {
    this.configCustomPaging = {
      id: "customPaging",
      itemsPerPage: 8,
      currentPage: 1,
      maxSize: 1,
      previousLabel: '',
      nextLabel: ''
    }
  }

  persons: Person[] = []
  person: Person = {
    id: 0,
    firstName: '',
    lastName: '',
    address: '',
    salary: 0,
    gender: 0,
    departmentId: ''
  }
  departments: Department[] = []
  searchText = ''
  configCustomPaging: any
  flash: any = true
  showLeftPanel: any = false


  ngOnInit(): void {
    this.getAllPersons()
    this.getAllDep()
  }

  getAllPersons() {
    this.personService.getAllPersons()
      .subscribe(arg => this.persons = arg)
  }

  getAllDep() {
    this.depService.getAllDepartments()
      .subscribe(arg =>
        this.departments = arg)
  }

  getDepById(id: string) {
    return this.departments.find((x) => x.id === id)?.name
  }

  turnOffFlash() {
    this.flash = false
  }
  toggleLeftPanel() {
    this.showLeftPanel = !this.showLeftPanel
  }

  submit() {
    this.personService.addPerson(this.person)
      .subscribe(() => {
        this.getAllPersons()
        this.person = {
          id: 0,
          firstName: '',
          lastName: '',
          address: '',
          salary: 0,
          gender: 0,
          departmentId: ''
        }
      }
      )
  }


  onPageChange(event: any) {
    this.configCustomPaging.currentPage = event
  }

}
