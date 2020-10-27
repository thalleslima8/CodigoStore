using CasaDoCodigo.Models;

namespace CodigoStore
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }
}