using System;
using System.Linq;

namespace Intex2.Models
{
    public interface IBowlersRepository
    {
        IQueryable<Collision> Collisions { get; }
        public void AddCollision(Collision collision);
        public void RemoveCollision(Collision collision);
        public void EditCollision(Collision collision);
    }
}
