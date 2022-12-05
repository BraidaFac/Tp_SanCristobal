import { Component, OnInit } from '@angular/core';
import { FormBuilder, NonNullableFormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/modules/auth/services/auth.service';
import { ICredenciales } from '../ICredenciales';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent  {

  constructor(private fb :FormBuilder, private _auth:AuthService,private _router:Router)
  { }
  passOrEmailError:boolean=false;
  authError:boolean=false
  loginForm=this.fb.group({
    email: this.fb.nonNullable.control("", {
      validators: [Validators.required, Validators.email],
    }),
    password:this.fb.nonNullable.control("",{
      validators:[Validators.required]})
    }
  )

  submit(){{
    if(!this.loginForm.valid){
      return
    }
    let credentials : ICredenciales = this.loginForm.value;
    this._auth.getAuthorizationToken(credentials).subscribe({
      next: (res)=> {
        localStorage.setItem('token',res.token);
      this.passOrEmailError=false;
      this._router.navigate(['/person'])},
      error:(err)=>{if(err.status==400){
        this.passOrEmailError=true;
        }
      }
    })

  }

}}
