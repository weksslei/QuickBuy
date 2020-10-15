using System.Collections.Generic;
using System.Linq;

namespace Quick.Dominio
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }//Alterar para private caso FormaPagamentoConfiguration tenha erro
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }
        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }
        protected void AdicionaCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();
        protected bool EhValidado
        {
            get { return !mensagemValidacao.Any(); }
        }

        
    }
        
}
