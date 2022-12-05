import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from 'src/app/modules/auth/services/auth.service';
import { IPersona } from '../ipersona';
import { PersonaService } from '../Services/persona.service';
/**
 * @title Basic use of `<mat-table>` (uses display flex)
 */
@Component({
  selector: 'app-consulta',
  templateUrl: './consulta.component.html',
  styleUrls: ['./consulta.component.css']
})
export class ConsultaComponent implements OnInit {
  datasource! :IPersona[];
  show:boolean=false;
  displayedColumns:string[]= ["id","name", "phoneNumber", "email", "city","address","Actualizar","Eliminar"]
  ;

  constructor(private _personaService: PersonaService, private _router :Router,private _auth :AuthService) {

   };

  logOut(){
    this._auth.logoutUser();
  }
  deletePerson(id:number){
      this._personaService.destroy(id).subscribe(
          res=>{
            console.log(res);
              const filtered = this.datasource.filter((item)=> item.id !== res.id );
              this.datasource=filtered;
          }
      );
  }
  update(id: number){
    this._router.navigate(['',id]);
  }

  ngOnInit() {
    this.show=true;
    this._personaService.getAll().subscribe({
      next: (res) => {this.datasource=res ;
                       this.show=false;},
      error: (err)=> {if(err.status==403){
        this._router.navigate(['/'])}
        }

    })
    setTimeout(this.actualizarLista.bind(this),600)
}
actualizarLista(){
   this._personaService.getAll().subscribe(res=>this.datasource=res);
}

}
