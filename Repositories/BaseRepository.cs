using CasaDoCodigo.Models;
using CodigoStore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoStore.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected readonly DbSet<T> dbSets;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            this.dbSets = contexto.Set<T>();
        }
    }
}
