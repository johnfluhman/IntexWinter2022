using System;
using System.Linq;

namespace Intex2.Models
{
    public interface ICollisionRepository
    {
        IQueryable<Collision> Collisions { get; }
        public void AddCollision(Collision collision);
        public void DeleteCollision(Collision collision);
        public void EditCollision(Collision collision);
    }
}
