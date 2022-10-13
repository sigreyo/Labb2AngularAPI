import { Injectable } from '@angular/core';

export interface ToastInfo {
  body: string;
  delay?: number;
}

@Injectable({
  providedIn: 'root'
})
export class ToastService {

  toasts: ToastInfo[] = [];

  show(body: string) {
    this.toasts.push({ body });
  }

  remove(toast: ToastInfo) {
    this.toasts = this.toasts.filter(t => t != toast);
  }
}

