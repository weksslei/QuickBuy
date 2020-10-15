using System;
using System.Collections.Generic;
using System.Text;
using Quick.Dominio.ObjetoDe;


namespace Quick.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public override void Validate()
        {
            if(Id != ProdutoId)
            { AdicionaCritica("Favor verificar se os Produtos estão conforme pedido."); }
            
            //throw new NotImplementedException();
        }
    }
}
