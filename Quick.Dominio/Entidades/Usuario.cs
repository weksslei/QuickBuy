using System.Collections.Generic;

namespace Quick.Dominio.Entidades
{
     public class Usuario :Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }


        //Sumary
        //    um usuario pode ter um ou muitos pedidos
        //    Sumary
        public virtual ICollection<Pedido> Pedidos  { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionaCritica("Email não foi informado!");
            //throw new System.NotImplementedException();
        }
    }
}
