import { Component, OnInit } from '@angular/core';
import { MdbModalRef } from 'mdb-angular-ui-kit/modal';
import { Person } from '../models/person.model';
import { PersonComponent } from '../person/person.component';
import { ToastService } from '../toastservice.service';

@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.css']
})
export class ModalComponent {
  personid: number | undefined

  constructor(public modalRef: MdbModalRef<ModalComponent>,
    public person: PersonComponent) { }

  deletePerson(id: any) {
    this.person.deletePerson(id)
    window.location.reload()
  }


}
