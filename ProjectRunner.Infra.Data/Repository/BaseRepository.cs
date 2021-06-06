using ProjectRunner.Entities;
using ProjectRunner.Infra.Data.Context;
using ProjectRunner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRunner.Infra.Data.Repository
{
    public class BaseRepository<Entity> : IRepository<Entity> where Entity : BaseEntity
    {
        protected readonly SQLiteContext _SQLiteContext;

        public BaseRepository(SQLiteContext SQLiteContext)
        {
            _SQLiteContext = SQLiteContext;
        }

        public void Insert(Entity obj)
        {
            _SQLiteContext.Set<Entity>().Add(obj);
            _SQLiteContext.SaveChanges();
        }

        public void Update(Entity obj)
        {
            _SQLiteContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _SQLiteContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _SQLiteContext.Set<Entity>().Remove(Select(id));
            _SQLiteContext.SaveChanges();
        }

        public IList<Entity> Select() =>
            _SQLiteContext.Set<Entity>().ToList();

        public Entity Select(int id) =>
            _SQLiteContext.Set<Entity>().Find(id);

    }
}
