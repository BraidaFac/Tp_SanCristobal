import { Component, Input, OnInit } from '@angular/core';
import { SpinnerService } from './spinner.service';

@Component({
  selector: 'app-spinner',
  template: `<div *ngIf="show|| (isLoading$|async)" id="loader" class="overlay">
             <div class="one"></div>
             <div class="two"></div>
             <div class="three"></div>
</div>`,
  styleUrls: ['./spinner.component.css']
})
export class SpinnerComponent implements OnInit {
  isLoading$ =this._spinnerService.isLoading$;
  @Input() show: boolean=false;;
  constructor(private readonly _spinnerService :SpinnerService) {

   }

  ngOnInit(): void {
  }

}
