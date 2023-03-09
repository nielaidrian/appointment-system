using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using SbcCapstone.Contracts;
using SbcCapstone.Data;

namespace SbcCapstone.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
       
        private readonly DbContext _db;
        private readonly DbSet<T> _table;

        public BaseRepository(ApplicationDbContext db)
        {
            _db = db;
            _table = db.Set<T>();
        }
        public async Task Create(T t)
        {
            await _table.AddAsync(t);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task GetOne(object id)
        {
             await _table.FindAsync(id);
        }

        public async Task Update(object id, object model)
        {
            var t = GetOne(id);
            if (t != null)
            {
                _db.Entry(t).CurrentValues.SetValues(model);
                await _db.SaveChangesAsync();
            }
        }
        public async Task Delete(object id)
        {
            //var t =   GetOne(id);
            if (id != null)
            {
                _table.Remove((T)id);
                await _db.SaveChangesAsync();
            }
        }
    }

   
}
