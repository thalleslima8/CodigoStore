using CasaDoCodigo.Models;
using CodigoStore.Models;
using CodigoStore.Models.ViewModels;
using CodigoStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoStore.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;
        private readonly IItemPedidoRepository itemPedidoRepository;

        public PedidoController(IProdutoRepository produtoRepository, IPedidoRepository pedidoRepository,
            IItemPedidoRepository itemPedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
            this.itemPedidoRepository = itemPedidoRepository;
        }

        public IActionResult Cadastro()
        {
            var pedido = pedidoRepository.GetPedido();
            
            if(pedido == null)
            {
                return RedirectToAction("Carrossel");
            }




            return View();
        }

        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                pedidoRepository.AddItem(codigo);
            }
            //Pedido pedido = pedidoRepository.GetPedido(); 
            List<ItemPedido> itens = pedidoRepository.GetPedido().Itens;
            CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(itens);

            return base.View(carrinhoViewModel);
        }

        public IActionResult Carrossel()
        {
            return View(produtoRepository.GetProdutos());
        }

        [HttpPost]
        public IActionResult Resumo(Cadastro cadastro)
        {
            var pedido = pedidoRepository.GetPedido();
            return View(pedido);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public UpdateQuantidadeResponse UpdateQuantidade([FromBody]ItemPedidoIdDto itemAjaxRequest)
        {
            var pedidoAtual = pedidoRepository.GetPedido();
            var itemPedido = itemPedidoRepository.GetItemPedido(itemAjaxRequest.Id);
            
            
            itemPedido.AtualizaQuantidade(itemAjaxRequest.Qtd);
            return pedidoRepository.UpdateQuantidade(itemPedido);
       }

    }
}
