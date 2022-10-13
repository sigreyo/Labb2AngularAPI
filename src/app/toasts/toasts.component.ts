import { Component } from '@angular/core';
import { ToastService } from '../toastservice.service';

@Component({
  selector: 'app-toasts',
  template: `<ngb-toast *ngFor="let toast of toastService.toasts" [autohide]="true"
  [delay] = "toast.delay || 5000"(hidden) = "toastService.remove(toast)" > {{ toast.body }}</ngb-toast>`,
  styleUrls: ['./toasts.component.css']
})
export class ToastsComponent {

  constructor(public toastService: ToastService) { }

  showDeleteSuccess() {
    this.toastService.show("Deletion succeeded!");
  }

  showAddSuccess() {
    this.toastService.show("Person added!");
  }

}
