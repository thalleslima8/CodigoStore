﻿using System.Collections.Generic;

namespace CodigoStore.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
    }
}