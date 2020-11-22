import { Component, NgModule, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { CommonModule } from "@angular/common";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

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

export class LoginComponent implements OnInit {
  public usuario;
  public returnUrl: string;
  public mensagem: string;
  private ativar_spinner:  boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {

  }
  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
    }
  entrar() {
    this.ativar_spinner = true;
    this.usuarioServico.verificarUsuario(this.usuario)
      .subscribe(
        usuario_json => {
          // essa linha será executada no caso de retorno sem erros
          this.usuarioServico.usuario = usuario_json;
          
          //sessionStorage.setItem("usuario-autenticado", "1"); Deixou a linha comentada
         //  sessionStorage.setItem("email-usuario", usuarioRetorno.email); Professor disse que nao precisava mais dessa informação aula 107 

          if (this.returnUrl == null) {
            this.router.navigate(['/']);
          } else {
            this.router.navigate([this.returnUrl]);
          }
        },
        err => {
          console.log(err.error);
          this.mensagem = err.error;
          this.ativar_spinner = false;

        }
      );



    //if (this.usuario.email == "weksslei@live.com" && this.usuario.senha == "250980") {
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  this.router.navigate([this.returnUrl]);
      
    // }

//alert(this.usuario.email +"-"+ this.usuario.senha);
  }
}

