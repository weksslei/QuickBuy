import { Component, NgModule } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { CommonModule } from "@angular/common";

@Component({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls: ["./login.component.css"]
})
//@NgModule({
//  declarations: [
//    LoginComponent,],
//  imports: [
//    CommonModule],
//  exports: [
//    LoginComponent],
//  providers:[]})

export class LoginComponent {
  public usuario
 
 
  constructor() {
    this.usuario = new Usuario();
  }
  entrar() {
    if (this.usuario.email == "weksslei@live.com" && this.usuario.senha == "250980") {
      
     }

//alert(this.usuario.email +"-"+ this.usuario.senha);
  }
}

