import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable, Subject, tap } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IPersona } from '../ipersona';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {
  private _refreshrequired = new Subject<void>();

  get Refreshrequired(){
    return this._refreshrequired;
  }
  constructor(private _http: HttpClient) { }

  addPerson(person:IPersona):Observable<any>{
    console.log(person);
    return this._http.post<any>(environment.endPointApiPerson, {...person});
  }
  getAll(){
    return this._http.get<IPersona[]>(environment.endPointApiPerson);
  }
  getOne(id?:string){
    return this._http.get<IPersona>(`${environment.endPointApiPerson}/${id}`,);
  }
  updatePerson(persona:IPersona){
    return this._http.put<IPersona>(`${environment.endPointApiPerson}/${persona.id}`,persona);
  }

  destroy(id:number) :Observable<IPersona>{
    return this._http.delete<IPersona>(`${environment.endPointApiPerson}/${id}`).pipe(
      tap(()=>{
        this.Refreshrequired.next();
      })
    );
  }
}
