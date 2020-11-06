using CasaDoCodigo.Models;
using CodigoStore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoStore.Repositories
{
    public interface ICadastroRepository
    {
        Cadastro Update(int cadastroId, Cadastro novoCadastro);
    }
    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public Cadastro Update(int cadastroId, Cadastro novoCadastro)
        {
            throw new NotImplementedException();
        }
    }
}
