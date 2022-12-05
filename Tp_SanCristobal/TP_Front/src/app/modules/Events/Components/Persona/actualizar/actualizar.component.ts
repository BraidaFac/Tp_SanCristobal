import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { IPersona } from '../ipersona';
import { PersonaService } from '../Services/persona.service';

@Component({
  selector: 'app-actualizar',
  templateUrl: './actualizar.component.html',
  styleUrls: ['./actualizar.component.css']
})
export class ActualizarComponent implements OnInit {
  id!:number;
  changuePerson!:IPersona;
    constructor(private personService: PersonaService, private router:Router, private activatedRoute :ActivatedRoute, private fb :FormBuilder) {
      this.activatedRoute.data.subscribe(({ person }) => {
        console.log(person.id)
        this.id=person.id;

        this.personForm.controls.name.patchValue(person.name);
        this.personForm.controls.phoneNumber.patchValue(person.phoneNumber);
        this.personForm.controls.email.patchValue(person.email)
        this.personForm.controls.address.controls.city.patchValue(person.address.city);
        this.personForm.controls.address.controls.street.patchValue(person.address.street);
        this.personForm.controls.address.controls.number.patchValue(person.address.number);
      })



}

personForm=this.fb.group({
  name: this.fb.nonNullable.control('', {
    validators: [Validators.required],
  }),
  phoneNumber:this.fb.nonNullable.control('',{
    validators:[Validators.required]})
  ,
  email:this.fb.nonNullable.control('',{
    validators:[Validators.required,Validators.email]})
  ,
  address: this.fb.group({
    street: this.fb.nonNullable.control('',{
      validators:[Validators.required]
    }),
    number: this.fb.nonNullable.control('',{
      validators:[Validators.required]
    }),
    city: this.fb.nonNullable.control('',{
      validators:[Validators.required]
    }),

  })})

submit(){
  if(!this.personForm.valid){
    return
  }
  this.changuePerson=this.personForm.value;
  this.changuePerson.id=this.id;

  this.personService.updatePerson(this.changuePerson).subscribe({
    next: async res=>{this.alerta("Se ha modificado correctamente");
                      this.router.navigate(['']);},
  error: err=>{ this.alerta("Error al actualizar");
                this.router.navigate([''])}
  });

}

ngOnInit(): void {



  }

alerta(message:string) {
  alert(message);

}
}

