using CasaDoCodigo.Models;
using CodigoStore.Context;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoStore.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext contexto;

        public ProdutoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public IList<Produto> GetProdutos()
        {
            return contexto.Set<Produto>().ToList();
        }

        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
                contexto.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
            }

            contexto.SaveChanges();
        }
    }

    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
