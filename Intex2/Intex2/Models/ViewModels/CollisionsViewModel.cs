using System;
using System.Linq;

namespace Intex2.Models.ViewModels
{
    public class CollisionsViewModel
    {
        public IQueryable<Collision> Collisions { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
