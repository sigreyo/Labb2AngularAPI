import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Person } from "../models/person.model";
import { HttpClient } from "@angular/common/http";



@Injectable({
    providedIn: "root"
})

export class PersonService{
    apiUrl="https://localhost:7287/api/person"
    constructor(private http:HttpClient){}


    getAllPersons():Observable<Person[]>{      
    return this.http.get<Person[]>(this.apiUrl)
  }

  addPerson(person:Person):Observable<Person>{
    return this.http.post<Person>(this.apiUrl, person)
  }

}
