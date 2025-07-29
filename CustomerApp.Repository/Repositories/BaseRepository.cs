using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Repository.Repositories
{
    public class BaseRepository<T> where T : class
    {

        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context) { 
            this._context = context;
        }

        public DatabaseFacade Database => _context.Database;
    }
}
