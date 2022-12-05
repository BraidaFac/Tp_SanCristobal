
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import {IPersona} from '../ipersona'
import { PersonaService } from '../Services/persona.service';
@Component({
  selector: 'app-alta',
  templateUrl: './alta.component.html',
  styleUrls: ['./alta.component.css']
})
export class AltaComponent implements OnInit {

  constructor(private fb :FormBuilder, private _router:Router,private personService:PersonaService) { }
  ngOnInit(): void {
  }

  personForm=this.fb.group({
    name: this.fb.nonNullable.control("", {
      validators: [Validators.required],
    }),
    phoneNumber:this.fb.nonNullable.control("",{
      validators:[Validators.required]})
    ,
    email:this.fb.nonNullable.control("",{
      validators:[Validators.required,Validators.email]})
    ,
    address: this.fb.group({
      street: this.fb.nonNullable.control("",{
        validators:[Validators.required]
      }),
      number: this.fb.nonNullable.control("",{
        validators:[Validators.required]
      }),
      city: this.fb.nonNullable.control("",{
        validators:[Validators.required]
      }),

    })})

    submit(){{
      if(!this.personForm.valid){
        return
      }
      let person : IPersona = this.personForm.value;
      this.personService.addPerson(person).subscribe({
        next:res => {console.log("se agrego")
          this._router.navigate(['/person'])}
                    ,
        error: err=> console.log(err)}
      )

    }
  }
}
