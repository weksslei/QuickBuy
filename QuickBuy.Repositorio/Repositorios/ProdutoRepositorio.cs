using Quick.Dominio.Contratos;
using Quick.Dominio.Entidades;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}
