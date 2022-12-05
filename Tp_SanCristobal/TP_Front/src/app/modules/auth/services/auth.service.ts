import { Injectable } from '@angular/core';
import { ICredenciales } from '../ICredenciales';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private _http: HttpClient, private _router:Router) { }

  getAuthorizationToken(credentials: ICredenciales):Observable<any>{

      return  this._http.post<any>(environment.endPointApiLog,{...credentials});
  }

  logoutUser()
  {
    localStorage.removeItem('token')
    this._router.navigate(['/login'])
  }
  loggedIn()
  {
    return  !!localStorage.getItem('token');
  }
  getToken()
    {
     return localStorage.getItem('token')
      }

}
