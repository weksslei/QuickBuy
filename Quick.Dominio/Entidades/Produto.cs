using System;
using System.Collections.Generic;
using System.Text;

namespace Quick.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string NomeArquivo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionaCritica("Nome do produto não foi informado!");


            if (string.IsNullOrEmpty(Descricao))
                AdicionaCritica("Descrição do produto não foi informada!");

        }
    }
}
