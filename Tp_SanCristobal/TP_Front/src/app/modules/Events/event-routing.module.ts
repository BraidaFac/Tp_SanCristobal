import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuardGuard } from '../auth/guards/auth-guard.guard';
import { ActualizarComponent } from './Components/Persona/actualizar/actualizar.component';
import { AltaComponent } from './Components/Persona/alta/alta.component';
import { ConsultaComponent } from './Components/Persona/consulta/consulta.component';
import { ConsultaResolver } from './Resolver/consulta.resolver';

const routes: Routes = [{
  path:'',
  component: ConsultaComponent,canActivate: [AuthGuardGuard],
},
{
  path:'alta', pathMatch: 'full',
  component:AltaComponent,canActivate: [AuthGuardGuard]
},
{
  path:':id',
  component:ActualizarComponent, canActivate:[AuthGuardGuard],
  resolve: {person: ConsultaResolver}
}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EventRoutingModule { }
