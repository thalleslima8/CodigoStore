using CasaDoCodigo.Models;
using CodigoStore.Context;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CodigoStore
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;

        public DataService(ApplicationContext _context)
        {
            contexto = _context;
        }

        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();

            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);

            foreach (var livro in livros)
            {
                contexto.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
            }

            contexto.SaveChanges();

        }
    }

    class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }

     

}
