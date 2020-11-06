using CasaDoCodigo.Models;
using CodigoStore.Models;

namespace CodigoStore
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
        UpdateQuantidadeResponse UpdateQuantidade(ItemPedido itemPedido);

        Pedido UpdateCadastro(Cadastro cadastro);
    }
}