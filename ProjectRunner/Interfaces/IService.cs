using FluentValidation;
using ProjectRunner.Entities;
using System.Collections.Generic;

namespace ProjectRunner.Interfaces
{
    public interface IService<Entity> where Entity : BaseEntity
    {
        Entity Save<Validator>(Entity entity) where Validator : AbstractValidator<Entity>;
        void Destroy(int id);
        IList<Entity> All();
        Entity Find(int id);
    }
}
