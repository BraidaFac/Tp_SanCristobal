import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConsultaComponent } from './Components/Persona/consulta/consulta.component';
import { AltaComponent } from './Components/Persona/alta/alta.component';
import { ActualizarComponent } from './Components/Persona/actualizar/actualizar.component';
import { SharedModule } from '../shared/shared.module';
import { EventRoutingModule } from './event-routing.module';
import { LoginModule } from '../auth/login.module';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { AuthRoutingModule } from '../auth/auth-routing.module';
import { MaterialModule } from '../material/material.module';
import { AuthInterceptor } from '../auth/interceptors/auth.interceptor';
import { SpinnerInterceptor } from '../shared/spinner/spinner.interceptor';



@NgModule({
  declarations: [AltaComponent,
    ConsultaComponent,
    ActualizarComponent],
  imports: [
    CommonModule,
    SharedModule,
    EventRoutingModule,
    LoginModule,
    ReactiveFormsModule,
    HttpClientModule,
    AuthRoutingModule,
    MaterialModule
  ],
  exports:[
    ConsultaComponent,
    AltaComponent,
    ActualizarComponent,
  ],
  providers: [
    {provide:HTTP_INTERCEPTORS,
      useClass:AuthInterceptor,
      multi:true},{
      provide:HTTP_INTERCEPTORS,
    useClass:SpinnerInterceptor,
    multi:true}
  ]
})
export class EventsModule { }
