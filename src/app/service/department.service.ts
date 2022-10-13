import { Injectable } from '@angular/core';
import { Department } from '../models/department.model';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  apiUrl="https://localhost:7287/api/department"
  constructor(private http:HttpClient){}

  getAllDepartments():Observable<Department[]>{
    return this.http.get<Department[]>(this.apiUrl)    
  }
}
