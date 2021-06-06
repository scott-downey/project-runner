using ProjectRunner.Entities;
using System.Collections.Generic;

namespace ProjectRunner.Interfaces
{
    public interface IRepository<Entity> where Entity : BaseEntity
    {
        void Insert(Entity entity);
        void Update(Entity entity);
        void Delete(int id);
        IList<Entity> Select();
        Entity Select(int id);
    }
}
