import { Pipe, PipeTransform } from '@angular/core';
import { Person } from './models/person.model';
import { PersonComponent } from './person/person.component';

@Pipe({
  name: 'search'
})


export class SearchPipe implements PipeTransform {

  transform(value: any, args?:any): any {
    if (!value) return null
    if (!args) return value

    args = args.toLowerCase()

    return value.filter((item:string)=>{
      return JSON.stringify(item).toLowerCase().includes(args)
    })
  }

}
