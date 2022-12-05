import { Injectable } from '@angular/core';
import {
  Router, Resolve,
  RouterStateSnapshot,
  ActivatedRouteSnapshot
} from '@angular/router';
import { Observable, of } from 'rxjs';
import { IPersona } from '../Components/Persona/ipersona';
import { PersonaService } from '../Components/Persona/Services/persona.service';

@Injectable({
  providedIn: 'root'
})
export class ConsultaResolver implements Resolve<IPersona> {
  constructor(private _personService:PersonaService){};
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<IPersona> | Promise<IPersona>{
    let id=route.paramMap.get('id');
    if(!id){
      id='';
    }
    return this._personService.getOne(id);

  }
}
