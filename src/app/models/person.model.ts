import { Department } from "./department.model"

export interface Person {
    id: number,
    firstName: string,
    lastName: string,
    address: string,
    salary: number,
    gender: number,
    departmentId: string
}