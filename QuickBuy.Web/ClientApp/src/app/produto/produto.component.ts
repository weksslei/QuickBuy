import { Component, OnInit } from "@angular/core"
import { Produto } from "../modelo/produto";
import { ProdutoServico } from "../servicos/produto/produto.servico";
import { Router } from "@angular/router";

@Component({
  selector: "app-produto",
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]
})
//Nome das classes começando com maisculo por conta da convenção PascalCase
export class ProdutoComponent implements OnInit {
  public produto: Produto
  public arquivoSelecionado: File;
  public ativar_spinner: boolean;
  public mensagem: string;

  constructor(private produtoServico: ProdutoServico, private router: Router) {

  }


  ngOnInit(): void {
    var produtoSession = sessionStorage.getItem('produtoSession');
    if (produtoSession) {
      this.produto = JSON.parse(produtoSession);
    } else 
      this.produto = new Produto();
    
  }
  public inputChange(files: FileList) {
    this.arquivoSelecionado = files.item(0);
    this.ativar_spinner = true;
   // alert(this.arquivoSelecionado.name);
    this.produtoServico.enviarArquivo(this.arquivoSelecionado)
      .subscribe(
        nomeArquivo => {
          this.produto.nomeArquivo = nomeArquivo;
          console.log(nomeArquivo);
          this.ativar_spinner = false;
        },
        e => {
          console.log(e.error);
          this.ativar_spinner = false;
        });
  }


  public cadastrar() {//em caso de operação bem sucedida esse bloco sera executado
    this.ativarEspera();
    //if (this.produto.id != null) {
    //  this.produto.id = null;
    //  alert("Limpando os campos")
    //}
     this.produtoServico.cadastrar(this.produto)
      .subscribe(
        produtoJson => {
          console.log(produtoJson);
          this.desativarEspera();
          this.router.navigate(['/pesquisar-produto'])
        },

        //caso nao seja bem sucedida esse bloco será executado.
        e => {
          console.log(e.error);
          this.mensagem = e.error;
          this.desativarEspera();
        }        
      );
  }
  public ativarEspera() {
    this.ativar_spinner = true;

  }
  public desativarEspera() {
    this.ativar_spinner = false;
  }
}
