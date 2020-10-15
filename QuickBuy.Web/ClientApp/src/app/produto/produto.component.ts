import { Component } from "@angular/core"

@Component({
    selector: "app-produto",
    template : " <html><body>{{ obterNome() }}</body></html> ",
})
//Nome das classes começando com maisculo por conta da convenção PascalCase
export class ProdutoComponent {
    /* camelCase para variáveis, atributos e nomes das funções*/
    public nome: string;
    public liberadoParaVenda: boolean;

    public obterNome(): string {
        return "Samsung";
    }
}
