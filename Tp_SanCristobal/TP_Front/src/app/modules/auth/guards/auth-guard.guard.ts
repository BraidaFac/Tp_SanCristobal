import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from '../services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardGuard implements CanActivate {
  constructor(private _authService:AuthService, private _rotuer:Router){}
  canActivate()  {
    if(this._authService.loggedIn()){
      console.log(true)
    return true;
    }
    else {
      console.log(false)
      this._rotuer.navigate(['/login']);

    return false
  }}

}
