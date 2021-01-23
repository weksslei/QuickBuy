import { OnInit, Component } from "@angular/core"
import { Produto } from "../../modelo/produto";
import { ProdutoServico } from "../../servicos/produto/produto.servico";

@Component({
  selector: "app-loja",
  templateUrl: "./loja.pesquisa.component.html",
  styleUrls: ["./loja.pesquisa.component.css"]
})

export class LojaPesquisaComponent implements OnInit {

  public produtos: Produto[];


    ngOnInit(): void {
        throw new Error("Method not implemented.");
  }

  constructor(private produtoServico: ProdutoServico) {

  }

}
