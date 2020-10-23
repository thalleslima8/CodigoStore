using CodigoStore.Context;

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
        }
    }

}
