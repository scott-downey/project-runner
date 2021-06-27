using FluentValidation;
using ProjectRunner.Common.Entities;
using System.Collections.Generic;

namespace ProjectRunner.Common.Interfaces
{
    public interface IRepositoryService<Entity> where Entity : BaseEntity
    {
        Entity Save<Validator>(Entity entity) where Validator : AbstractValidator<Entity>;
        void Destroy(int id);
        IList<Entity> All();
        Entity Find(int id);
    }
}
