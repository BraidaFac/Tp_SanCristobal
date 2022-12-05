import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginModule } from './modules/auth/login.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SharedModule } from './modules/shared/shared.module';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { SpinnerInterceptor } from './modules/shared/spinner/spinner.interceptor';
import { AuthInterceptor } from './modules/auth/interceptors/auth.interceptor';


@NgModule({
  declarations: [
    AppComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    LoginModule,
    BrowserAnimationsModule,
    SharedModule
  ],
  providers: [
    {provide:HTTP_INTERCEPTORS,
    useClass:SpinnerInterceptor,
    multi:true},
    ],
  bootstrap: [AppComponent]
})
export class AppModule { }
