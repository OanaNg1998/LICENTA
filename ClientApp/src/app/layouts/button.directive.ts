import { Directive, ElementRef } from '@angular/core';

@Directive({
  selector: '[appbutton]'
})
export class ButtonDirective {
  constructor(el: ElementRef) {
    el.nativeElement.style.color = '#bf00ff';
  }
}

