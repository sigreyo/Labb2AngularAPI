import { Component, OnInit } from '@angular/core';
import { Department } from '../models/department.model';

import { Person } from '../models/person.model';
import { PersonService } from '../service/person.service';
import { DepartmentService } from '../service/department.service';
import { ToastsComponent } from '../toasts/toasts.component';


@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})

export class PersonComponent implements OnInit {

  constructor(
    private personService: PersonService,
    private depService: DepartmentService,
    private toast: ToastsComponent) {
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

  deletePerson(id: number) {
    this.personService.deletePerson(id).subscribe(() =>
      this.getAllPersons())
    this.toast.showDeleteSuccess()

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
    this.toast.showAddSuccess()
  }


  onPageChange(event: any) {
    this.configCustomPaging.currentPage = event
  }

  showDeleteSuccess() {
    this.toast.showDeleteSuccess()
  }

  showAddSuccess() {
    this.toast.showAddSuccess()
  }

}
