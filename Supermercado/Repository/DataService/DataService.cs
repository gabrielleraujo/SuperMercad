using Microsoft.EntityFrameworkCore;
using Supermercado.Interfaces;
using Supermercado.Repository.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Repository.DataService
{
    public class DataService : IDataService, IDisposable
    {
        private readonly SupermercadoDbContext _context;

        public DataService(SupermercadoDbContext context)
        {
            _context = context;
        }

        public void InicializarDb()
        {
            _context.Database.Migrate();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
