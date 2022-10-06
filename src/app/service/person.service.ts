import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Person } from "../models/person.model";
import { HttpClient } from "@angular/common/http";



@Injectable({
    providedIn: "root"
})

export class PersonService{
    apiUrl="https://localhost:7287/api/person"
    constructor(private httpClient:HttpClient){}


    getAllPersons():Observable<Person[]>{      
    return this.httpClient.get<Person[]>(this.apiUrl)
  }



}
