using CasaDoCodigo.Models;
using CodigoStore.Context;
using CodigoStore.Repositories;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CodigoStore
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext _context, IProdutoRepository produtoRepository)
        {
            contexto = _context;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();
            List<Livro> livros = GetLivros();
            produtoRepository.SaveProdutos(livros);

        }

        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }
}
