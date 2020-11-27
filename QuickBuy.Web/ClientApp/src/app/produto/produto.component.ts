import { Component, OnInit } from "@angular/core"
import { Produto } from "../modelo/produto";
import { ProdutoServico } from "../servicos/produto/produto.servico";

@Component({
  selector: "app-produto",
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]
})
//Nome das classes começando com maisculo por conta da convenção PascalCase
export class ProdutoComponent implements OnInit {
  public produto: Produto

  constructor(private produtoServico: ProdutoServico) {

  }


  ngOnInit(): void {
    this.produto = new Produto();
  }
  public cadastrar() {//em caso de operação bem sucedida esse bloco sera executado
    this.produtoServico.cadastrar(this.produto)
      .subscribe(
        produtoJson => {
          console.log(produtoJson);
        },

        //caso nao seja bem sucedida esse bloco será executado.
        e => {
          console.log(e.error);
        }        
      );
  }
 
}
